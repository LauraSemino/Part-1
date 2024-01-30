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
        Debug.Log("trigger from " + collision.gameObject);
        RespawnPlayer(collision.gameObject);
    }
    private void RespawnPlayer(GameObject player)
    {
        WASDBlue.transform.position = respawnB.position;
        ArrowRed.transform.position = respawnR.position;
        WASDBlue.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        ArrowRed.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }
}
