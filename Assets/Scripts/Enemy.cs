using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int maxHealth;

    private float _health;
    private NavMeshAgent _agent;
    
    // Start is called before the first frame update
    void Start()
    {
        _health = maxHealth;
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amnt)
    {
        _health -= amnt;
    }
}
