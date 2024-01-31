using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBarrelDie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //kills a victory barrel when it goes off screen
        if (transform.position.y < -8)
        {
            Destroy(gameObject);
        }
    }
}
