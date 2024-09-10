using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol_Puntos : MonoBehaviour
{

    public bool p1Gol;
    public GameManager gameManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ball"))
        {

            if (p1Gol)
            {
                gameManager.Player1Scored();
            }
            else
            {
                gameManager.Player2Scored();
            }

        }
    }
}

