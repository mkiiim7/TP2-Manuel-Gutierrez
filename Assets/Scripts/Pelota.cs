using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    [SerializeField] private float pelota_speed = 7f;
    [SerializeField] Rigidbody2D pelota_rb;
    [SerializeField] PhysicsMaterial2D physicsMaterial2D;
    [SerializeField] Vector2 pelota_start_pos;
    void Start()
    {
        transform.position = pelota_start_pos;
        Lanzamiento_Inicial();
    }

    private void Update()
    {
       
       
    }

    public void Reset()
    { 
       
        transform.position = pelota_start_pos;
        
        pelota_rb.velocity = Vector2.zero;

        Lanzamiento_Inicial();
    }  
    
   public void Lanzamiento_Inicial()
    {
        int x = Random.Range(-1, 2)  ;

        while (x == 0)
        {
            x = Random.Range(-1, 2);
        }



        int y = Random.Range(-1, 2)  ;

        while (y == 0)
        {
            y = Random.Range(-1, 2);
        }

        pelota_rb.velocity = new Vector2(pelota_speed * x * Time.deltaTime*50 , pelota_speed * y * Time.deltaTime*50); 

    }

}