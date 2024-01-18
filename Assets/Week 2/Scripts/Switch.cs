using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    SpriteRenderer spriterenderer;
    public Color myColor;
    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        spriterenderer.color = myColor;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger from " + collision.gameObject);
        spriterenderer.color = Color.red;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        spriterenderer.color = myColor;
    }
}
