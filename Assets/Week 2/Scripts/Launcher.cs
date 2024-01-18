using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject misslePreFab;
    public Transform spawnpoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(misslePreFab, spawnpoint.position, spawnpoint.rotation);
    }
}
