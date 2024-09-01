using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private int score = 10;
    private float life = 100;
    public float speed = 0.01f;
    public float speed2 = 0.01f;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed2;
        }

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed2;
        }

        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, 10f));

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, -10f));

        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            float red = Random.Range(0, 1.0f);
            float green = Random.Range(0, 1.0f);
            float blue = Random.Range(0, 1.0f);
            spriteRenderer.color = new Color(red, green, blue) ;

        }

    }

}