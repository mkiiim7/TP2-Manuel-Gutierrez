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
    public float speed2 = 0.01f;

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(keyUp))
        {
            pos.y += speed2 * Time.deltaTime * 1000;
        }

        if (Input.GetKey(keyDown))
        {
            pos.y -= speed2 * Time.deltaTime * 1000;
        }

        if (Input.GetKey(keyLeft))
        {
            pos.x -= speed2 * Time.deltaTime * 1000;
        }

        if (Input.GetKey(keyRight))
        {
            pos.x += speed2 * Time.deltaTime * 1000;
        }

        transform.position = pos;
    }

   

}
