using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    private int score = 10;
    public KeyCode keyUp = KeyCode.UpArrow;
    public KeyCode keyDown = KeyCode.DownArrow;
    public KeyCode keyLeft = KeyCode.LeftArrow;
    public KeyCode keyRight = KeyCode.RightArrow;
    public float speed = 0.01f;
    public float speed2 = 0.01f;

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(keyUp))
        {
            pos.y += speed;
        }

        if (Input.GetKey(keyDown))
        {
            pos.y -= speed;
        }

        if (Input.GetKey(keyLeft))
        {
            pos.x -= speed2;
        }

        if (Input.GetKey(keyRight))
        {
            pos.x += speed2;
        }

        transform.position = pos;
    }

}
