using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    /*
     * TODO:
     *    [✔] Handle Keyboard Input
     *    [✔] Use that input to change the position of our object
     *         [✔] How to access position
     *         [✔] How to change position 
     */

    private CharacterController _controller;
    private Vector3 direction;

    public float speed;
    public float mass;
    
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float left_and_right = Input.GetAxis("Horizontal");
        float forward_and_back = Input.GetAxis("Vertical");
        direction = new Vector3(left_and_right, 0,forward_and_back).normalized * speed;
        _controller.SimpleMove(direction);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        hit.rigidbody?.AddForce(direction * speed * mass);
    }
}
