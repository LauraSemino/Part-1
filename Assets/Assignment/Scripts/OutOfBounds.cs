using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public Transform respawnR;
    public Transform respawnB;
    public GameObject WASDBlue;
    public GameObject ArrowRed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //respawns the player if they go out of bounds, and then detects which player went out of bounds and sends a signal to the losing player so a victory barrel gets
        //dropped for the other player
        Debug.Log("trigger from " + collision.gameObject);
        RespawnPlayer(collision.gameObject);
        switch (collision.gameObject.ToString())
        {
            case "WASDBlue (UnityEngine.GameObject)":
                GameObject.Find("WASDBlue").GetComponent<WASDCar>().haslost = true;
                break;
            case "ArrowRed (UnityEngine.GameObject)":
                GameObject.Find("ArrowRed").GetComponent<ArrowCar>().haslost = true;
                break;
        }
       
    }
    private void RespawnPlayer(GameObject player)
    {
        //respawns the players and nulls their velocity
        WASDBlue.transform.position = respawnB.position;
        ArrowRed.transform.position = respawnR.position;
        WASDBlue.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        ArrowRed.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }
}
