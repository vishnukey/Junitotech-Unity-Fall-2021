using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    private MeshRenderer renderer;

    public Color colour;
    
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material.color = colour;
        // Material mat = renderer.material;
        // mat.color = colour;
    }
}
