using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamage : MonoBehaviour
{
    public float damageAmnt;
    public float damageTimeout;
    
    private float _damageTimer = 0;

    private void OnTriggerEnter(Collider other)
    {
        Player? p = other.gameObject.GetComponent<Player>();
        p?.TakeDamage(damageAmnt);
        _damageTimer = 0;
    }

    private void OnTriggerStay(Collider other)
    {
        _damageTimer += Time.deltaTime;
        if (_damageTimer > damageTimeout)
        {
            Player? p = other.gameObject.GetComponent<Player>();
            p?.TakeDamage(damageAmnt);
            _damageTimer = 0;
        }
    }
}
