using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    private int score = 10;
    [SerializeField] private KeyCode keyUp = KeyCode.UpArrow; 
    [SerializeField] private KeyCode keyDown = KeyCode.DownArrow;
    [SerializeField] private KeyCode keyLeft = KeyCode.LeftArrow;
    [SerializeField] private KeyCode keyRight = KeyCode.RightArrow;
    

    //public float speed = 0.01f;
    public float speed2 = 3f;

    private Rigidbody2D rb;

    private void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
       

        if (Input.GetKey(keyUp))
        {
            rb.AddForce(Vector2.up * speed2 * Time.deltaTime * 1000);
        }

        if (Input.GetKey(keyDown))
        {
            rb.AddForce(new Vector2(0, -1) * speed2 * Time.deltaTime * 1000);  // new Vector2(0,-1) == Vector2.down
        }

        if (Input.GetKey(keyLeft))
        {
            rb.AddForce(Vector2.left * speed2 * Time.deltaTime * 1000);
        }

        if (Input.GetKey(keyRight))
        {
            rb.AddForce(Vector2.right * speed2 * Time.deltaTime * 1000);
        }

        
    }

   

}
