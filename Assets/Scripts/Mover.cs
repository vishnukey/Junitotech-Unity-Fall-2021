using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public Transform start;
    public Transform end;
    public float speed;

    private float t = 0;
    private Rigidbody _body;

    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * speed;
        Vector3 newPos = Vector3.Lerp(
            start.position,
            end.position,
            (-Mathf.Cos(t) + 1) / 2
        );
        //transform.position = newPos;
        _body.MovePosition(newPos);
    }
}
