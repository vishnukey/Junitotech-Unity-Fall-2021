using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class Enemy : MonoBehaviour
{
    public int maxHealth;
    public float radius;
    public float reach;
    public float attackCooldown;
    public float strength;

    private float _health;
    private NavMeshAgent _agent;
    private float _attackTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        _health = maxHealth;
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _attackTimer += Time.deltaTime;
        var hits = Physics.SphereCastAll(transform.position, radius, Vector3.up, radius);
        var target =
            (from hit in hits
            where hit.collider.CompareTag("Player")
            select hit.transform).FirstOrDefault();
        if (!(target is null))
        {
            var player = target.gameObject.GetComponent<Player>();
            var d = (transform.position - (target.position + target.localScale.y * target.up)).sqrMagnitude;
            if (_attackTimer > attackCooldown &&  d <= reach * reach)
            { 
                player.TakeDamage(strength);
                _attackTimer = 0;
            }

            if (d <= reach * reach)
            {
                // Debug.DrawLine(transform.position, target.position, Color.green);
                Debug.DrawLine(transform.position, target.position + target.localScale.y * target.up, Color.green);
            }
            else
            {
                // Debug.DrawLine(transform.position, target.position, Color.red);
                Debug.DrawLine(transform.position, target.position + target.localScale.y * target.up, Color.red);
            }
            
            Debug.Log($"distance to player is {Mathf.Sqrt(d)}");

            _agent.SetDestination(target.position);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, radius);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, reach);
    }

    public void TakeDamage(float amnt)
    {
        _health -= amnt;
    }
}
