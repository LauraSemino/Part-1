using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ArrowCar : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 400;
    public bool haslost = false;
    public GameObject bWin;
    public GameObject bWinSpawn;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //for movement
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
        if (haslost)
        {
            //Checks if the player has lost, and drops a victor barrel for the other player
            Instantiate(bWin, bWinSpawn.transform.position, bWinSpawn.transform.rotation);
            haslost = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //adds some bounce on collision with another player
        //physics arent perfect but it is the best I can do without actually using the physics function
        
        Vector2 force = (15*(-enemy.transform.position * speed * Time.deltaTime));
        rb2d.AddForce(force);
    }
}