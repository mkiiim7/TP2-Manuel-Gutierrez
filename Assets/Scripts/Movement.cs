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

    public UI_MAinMenu2 pausaUI ;

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
            pos.y += speed1* Time.deltaTime*1000;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed1 * Time.deltaTime*1000;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed1*Time.deltaTime * 1000;
        }

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed1*Time.deltaTime * 1000;
        }

          
        transform.position = pos;


        


     
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