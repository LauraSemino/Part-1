using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    float ForwardInput;
    float SteeringInput;
    public float forwardSpeed = 800;
    public float steeringSpeed = 200;
    public float maxSpeed = 1000;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ForwardInput = Input.GetAxis("Vertical");
        SteeringInput = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rigidbody.AddTorque(SteeringInput * -steeringSpeed * Time.deltaTime);
        Vector2 force = (transform.up * ForwardInput * forwardSpeed * Time.deltaTime);
        if (rigidbody.velocity.magnitude < maxSpeed)
        { 
        rigidbody.AddForce(force);
        }
    }
}
