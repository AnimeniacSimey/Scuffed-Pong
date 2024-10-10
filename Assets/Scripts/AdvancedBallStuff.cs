using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedBallStuff : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        Player1Sprint();
        Player2Sprint();
    }

    void Player1Sprint(){
            if(Input.GetKey(KeyCode.A)){
            GameObject.Find("Player 1").GetComponent<Player1_Movement>().speed = 25;
        }

        if(Input.GetKeyUp(KeyCode.A)){ 
        GameObject.Find("Player 1").GetComponent<Player1_Movement>().speed = 10; 
        }  
        }

    void Player2Sprint(){
            if(Input.GetKey(KeyCode.RightArrow)){
            GameObject.Find("Player 2").GetComponent<Player2_Movement>().speed = 25;
        }

        if(Input.GetKeyUp(KeyCode.RightArrow)){ 
        GameObject.Find("Player 2").GetComponent<Player2_Movement>().speed = 10; 
        }  
        }
    
}
