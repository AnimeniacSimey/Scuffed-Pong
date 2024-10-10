using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int Player1_Score;
    public int Player2_Score;

    public Text textObject;
    public Text Two;

    

    public void Player1Score(){ //Called from BallMovement.cs when ball collides with Player2Net
        Player1_Score++; //Adds one to player 1's score; "[variable]++" is the same as "[variable] += 1"
        textObject = GameObject.Find("Player1Score").GetComponent<Text>();
        textObject.text = Player1_Score.ToString(); //Binds Player 1's score 
    }

    public void Player2Score(){ //Called from BallMovement.cs when ball collides with Player1Net
        Player2_Score++;
        Two = GameObject.Find("Player2Score").GetComponent<Text>();
        Two.text = Player2_Score.ToString();
    }
    
}
