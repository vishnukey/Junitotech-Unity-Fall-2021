using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    /*
     * - Go to a specific point
     * - Go to a new scene
     * - Go to a another Teleporter
     */

    public Teleporter destination;
    public Transform telePoint;
    private bool _active = true;

    private void OnTriggerEnter(Collider other)
    {
        if (_active && other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            other.gameObject.transform.position = destination.telePoint.position;
            destination._active = false;
            //SceneManager.LoadScene("Snowman");
            other.gameObject.SetActive(true);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(telePoint.position, destination.telePoint.position);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _active = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(telePoint.position, destination.telePoint.position, Color.blue);
    }
}
