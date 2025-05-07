using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Vector3 direction;
    public float baseSpeed = 1;
    Rigidbody rb;
    public float speed;

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
            double num = Random.Range(0.001f, 1f);
            rb.velocity = new Vector3(direction.x * (float)(baseSpeed * num), rb.velocity.y, direction.z * (float)(baseSpeed * num));
        }
    }
}
