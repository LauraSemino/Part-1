using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WASDCar : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 400;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector2 force = (transform.up * speed * Time.deltaTime);
            rb2d.AddForce(force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector2 force = (-transform.right * speed * Time.deltaTime);
            rb2d.AddForce(force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector2 force = (-transform.up * speed * Time.deltaTime);
            rb2d.AddForce(force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 force = (transform.right * speed * Time.deltaTime);
            rb2d.AddForce(force);
        }

    }
}
