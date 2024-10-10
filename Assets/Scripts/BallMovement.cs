using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BallMovement : MonoBehaviour
{   
    //Initialiing variables for program to use
    Player1_Movement Player1_Movement;
    ScoreCounter ScoreCounter;
    public float speed = 10;
    public Vector2 direction = new Vector2(1, 1);
    public Vector2 velocity;
   
    bool P1Score;
    bool P2Score;
    public Text HideSpace;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("MainMenu");
        }
        
        if(Input.GetKeyDown(KeyCode.Space)){ //Starts ball's movement pattern if Space is pressed
            HideSpace.gameObject.SetActive(false);
            speed = 10;
        }

        if(Input.GetKeyDown(KeyCode.Equals)){
            speed++;
        }
        /*If you want to understand what the code means/how vectors are calculated, I recommend this video, which is where 
        I learned it from: Sebastian Lague - Intro to Game Development (E07: Vectors): 
        https://www.youtube.com/watch?v=nWuekr5rUcg&list=PLFt_AvWsXl0fnA91TcmkRyhhixX9CO3Lw&index=9 */

        velocity = direction*speed;
        transform.position = ((Vector2)transform.position + velocity*Time.deltaTime);

    } 

        void OnCollisionEnter2D(Collision2D Collider ){ //Called when ball collides with certain objects, specified in following statements

            //Situations for basic movement (ie. Very start of a round)
            if (Collider.gameObject.tag == "TopBorder" || Collider.gameObject.tag == "BottomBorder"){ //Ball collides with top border
               direction.y *= -1;
            }
            else if (Collider.gameObject.tag == "LeftBorder" || Collider.gameObject.tag == "RightBorder"){ //Ball collides with Player 1's paddle
                direction.x *= -1;
                speed += 1;
            }

            //Restarting round when border is hit
            if (Collider.gameObject.tag == "Player1Net"){
               ScoreCounter = GameObject.Find("Left Border").GetComponent<ScoreCounter>();
               ScoreCounter.Player2Score(); //Calls function from ScoreCounter.cs; refer to comment there
               speed = 0;
               HideSpace.gameObject.SetActive(true);
               //SpamBall SpamBall = GameObject.Find("Player 1").GetComponent<SpamBall>();
               //SpamBall.PressFirstOn = true;

               transform.position = new Vector2(0.05f,0.08f);
            }
                else if (Collider.gameObject.tag == "Player2Net"){ 
                ScoreCounter = GameObject.Find("Left Border").GetComponent<ScoreCounter>();
                ScoreCounter.Player1Score();
                HideSpace.gameObject.SetActive(true);
                GameObject Player1 = GameObject.Find("Player 1");
                //SpamBall SpamBall = Player1.GetComponent<SpamBall>();

               //SpamBall.PressFirstOn = true;
            
                speed = 0;
                transform.position = new Vector2(0.05f,0.08f);

              
            }


        
               

            
        }
}

        


    
        
    

    
    
    

   
    

    

    
 

