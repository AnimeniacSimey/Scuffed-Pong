using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpamBall : MonoBehaviour
{

    public Text PressText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){       
            PressText.text = "Get ready...";
            SendToPlayer();
            PressText.text = "";
        }   

        // StartCoroutine(DisableMovement());

        // //Timer();
        // StartCoroutine(Spam()); 
        
        //Remember: Caroutine + IEnumertor + yield return new WaitForSeconds is the "easiest" way to "time.sleep" in Unity
        
    }


    void SendToPlayer(){
        var rng = Random.Range(0,2); 
        if(rng == 0){
            BallMovement BallMovement = GameObject.Find("Ball").GetComponent<BallMovement>();
            BallMovement.direction = new Vector2(1, 1);
        }
        
        if(rng == 1){
            BallMovement BallMovement = GameObject.Find("Ball").GetComponent<BallMovement>();
            BallMovement.direction = new Vector2(-1, 1);
        }
    }
    /*void Timer(){ //Whoever has most at the end (if they didn't get 50) gets the ball
        while (timer >= 0 && TimerOn == true){
            timer -= Time.time/360;
            
            timer = (Mathf.Round(timer*100f))/100.0f;
            if (timer < 0){
                timerText.gameObject.SetActive(false);
                timer = 3;
                TimerOn = false;
            }
            timerText.text = timer.ToString();
            break;
        }
    }*/

    // IEnumerator DisableMovement(){
    //     //PressMechanic PressMechanic = GameObject.Find("PressText").GetComponent<PressMechanic>();
    //     Player1_Movement P1Movement = GameObject.Find("Player 1").GetComponent<Player1_Movement>();
    //     Player2_Movement P2Movement = GameObject.Find("Player 2").GetComponent<Player2_Movement>();
        
    // while(PressMechanic.Waiting == true){
    //     //Player 1 fucked up
    //     if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.S)){
    //         P1Spam.text = "Too early :/";
    //         P1Movement.P1Moving = false;
    //         yield return new WaitForSeconds(2);
    //         P1Movement.P1Moving = true;
    //         P1Spam.text = "";
    //         P2Pressed = true;
    //         SendToWinner();
           
    //     }
    //     break;
    // }
    // while(PressMechanic.Waiting == true){
    //     //Player 2 fucked up
    //     if (Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.DownArrow)){
    //             P2Spam.text = "Too early :/";
    //             P2Movement.P2Moving = false;
    //             yield return new WaitForSeconds(2);
    //             P2Movement.P2Moving = true;    
    //             P2Spam.text = "";
    //             P1Pressed = true;
    //             SendToWinner();
                
    //         }
    //     break;
    //     }
    // }

    // IEnumerator Spam(){ //First one to press gets the ball

    // while (PressFirstOn == true && SpamOn == true){
        
    //     if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.S)){
    //         P1PressCount++;
    //         P1Spam.text = "Got it.";
    //         PressFirstOn = false;
    //         yield return new WaitForSeconds(0.5f);
    //         P2Pressed = true;
    //         P2Spam.text = "Too bad.";
    //         yield return new WaitForSeconds(1);
    //         SendToWinner();
    //         P2Pressed = false;
    //         BallMovement BallMovement = GameObject.Find("Ball").GetComponent<BallMovement>();
    //         BallMovement.speed = 10;
    //         P1Spam.text = " ";
    //         P2Spam.text = " ";
    //         SpamOn = false;
    //     }
        
    //     if (Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.DownArrow)){
    //         P2PressCount++;
    //         P2Spam.text = "Got it.";
    //         PressFirstOn = false;
    //         yield return new WaitForSeconds(0.5f);
    //         P1Pressed = true;
    //         P1Spam.text = "Too bad.";
    //         yield return new WaitForSeconds(1);
    //         SendToWinner();
    //         P1Pressed = false;
    //         BallMovement BallMovement = GameObject.Find("Ball").GetComponent<BallMovement>();
    //         BallMovement.speed = 10;
    //         P1Spam.text = " ";
    //         P2Spam.text = " ";
    //         SpamOn = false;
    //     }
        
    //     break;
     


     }


          
    

   


