using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;
    MeshRenderer renderer;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
        //GetComponent<MeshRenderer>().enabled = false;
        //GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {    
        if(Time.time > timeToWait)
        {
            // Debug.Log("3 Second has elapsed");
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
