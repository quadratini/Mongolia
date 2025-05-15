using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public float jumpForce;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && birdIsAlive) {
            birdRigidBody.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        logic.gameOver();
        birdIsAlive = false;
    }
}
