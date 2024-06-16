using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    float speed = 20f;

    Rigidbody rb;

    Vector3 velocity;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.down * speed;

    }

    private void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.velocity = rb.velocity.normalized * speed;
        velocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = Vector3.Reflect(velocity, collision.contacts[0].normal);
    }


}
