using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Coin : MonoBehaviour
{
    public float bobOffset;
    public float bobPeriod;
    public float rotSpeed;
    public int value = 1;

    private Vector3 _startPos;
    private Vector3 _peak;
    private Vector3 _base;
    private float _time = 0;

    // Start is called before the first frame update
    void Start()
    {
        _startPos = transform.position;
        _peak = _startPos + Vector3.up * bobOffset;
        _base = _startPos - Vector3.up * bobOffset;
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        transform.position = Vector3.Lerp(
            _peak,
            _base,
            (-Mathf.Cos(_time * bobPeriod) + 1) / 2
        );

        transform.rotation = Quaternion.Euler(0, _time * rotSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            player.AddScore(value);
            Destroy(gameObject);
        }
    }
}
