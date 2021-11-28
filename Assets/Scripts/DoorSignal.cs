using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSignal : MonoBehaviour
{
    public Animator door;

    public bool open;

    private void OnTriggerEnter(Collider other)
    {
        door.SetBool("Open", open);
    }
}
