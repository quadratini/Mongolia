using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 10;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void SetDirection(Vector3 direction)
    {
        this.direction = direction.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction != null)
        {
            //rb.velocity = direction * speed;
            rb.velocity = new Vector3(direction.x * speed, rb.velocity.y, direction.z * speed);
        }
    }
}
