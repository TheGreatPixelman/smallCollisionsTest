using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{

    Color startColor;
    Color detectedColor;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startColor = spriteRenderer.color;
        detectedColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"{transform.name} colliding with {collision.transform.name}");
        spriteRenderer.color = detectedColor;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log($"{transform.name} stopped colliding with {collision.transform.name}");
        spriteRenderer.color = startColor;
    }
}
