using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1;
    public float rotationSpeed = 100;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.y -= rotationSpeed * Time.deltaTime;
            transform.eulerAngles = currentRotation;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.y += rotationSpeed * Time.deltaTime;
            transform.eulerAngles = currentRotation;
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(rb.transform.forward * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-rb.transform.forward * speed);
        }
    }
}
