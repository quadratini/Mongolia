using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    public float groundDrag;
    public float speed = 1;
    public float rotationSpeed = 100;
    public float jumpForce = 10;
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

        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
            grounded = false;
        }

        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
        
        if (grounded) 
        {
            rb.drag = groundDrag;

        } 
        else
        {
            rb.drag = 0;
        }
        
        SpeedControl();
    }

    private void SpeedControl() {
        Vector3 flatVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (flatVelocity.magnitude > speed) {
            Vector3 limitedVelocity = flatVelocity.normalized * speed;
            rb.velocity = new Vector3(limitedVelocity.x, rb.velocity.y, limitedVelocity.z);
        }
    }
}
