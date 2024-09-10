using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Movement : MonoBehaviour
{
    private int score = 10;
    private float life = 100;
    public float speed1 = 0.01f;
    //public float speed2 = 0.01f;
    private Rigidbody2D rb;

    public UI_MAinMenu2 pausaUI ;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * speed1 * Time.deltaTime * 1000);
          
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            rb.AddForce(new Vector2(0,-1) * speed1 * Time.deltaTime * 1000);  // new Vector2(0,-1) == Vector2.down
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * speed1 * Time.deltaTime * 1000);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * speed1 * Time.deltaTime * 1000);
        }
         
       


        


     
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    

        //}

        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //   

        //}

        //if (Input.GetKeyUp(KeyCode.E))
        //{
        //    float red = Random.Range(0, 1.0f);
        //    float green = Random.Range(0, 1.0f);
        //    float blue = Random.Range(0, 1.0f);
        //    spriteRenderer.color = new Color(red, green, blue) ;

        //}

    }
    //private void OnDestroy()
    //{
        
    //    if (pausaUI.pausa = true)
    //    {
    //        speed1 = 0f;
    //        Debug.Log("Funicona");
    //    }
    //}
    

}