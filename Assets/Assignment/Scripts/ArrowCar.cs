using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ArrowCar : MonoBehaviour
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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector2 force = (transform.up * speed * Time.deltaTime);
            rb2d.AddForce(force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 force = (-transform.right * speed * Time.deltaTime);
            rb2d.AddForce(force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 force = (-transform.up * speed * Time.deltaTime);
            rb2d.AddForce(force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 force = (transform.right * speed * Time.deltaTime);
            rb2d.AddForce(force);
        }

    }
}