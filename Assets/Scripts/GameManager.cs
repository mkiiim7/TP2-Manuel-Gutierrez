using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


    [SerializeField] GameObject pelota;

    [SerializeField] GameObject player1;
    [SerializeField] GameObject player1_gol;

    [SerializeField] GameObject player2;
    [SerializeField] GameObject player2_gol;


    public TextMeshProUGUI player1_Text;
    public TextMeshProUGUI player2_Text;

    public int player1_Score;
    public int player2_Score;


    void Start()
    {
        
    }

  
   public void Player1Scored()
   { 
        player1_Score++; 
        player1_Text.text = player1_Score.ToString();
        Reset_Position();

    
   }

   public void Player2Scored()
   {
        player2_Score++;
        player2_Text.text = player2_Score.ToString();
        Reset_Position();


   }

    private void Reset_Position()
    {

    }

}
