// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using Random = System.Random;

// public class PressMechanic : MonoBehaviour
// {
//     Random GenTime = new Random();

//     public Text GO;
//     public bool Waiting;
        
//     //Remember to add the flashing GO later

//     IEnumerator StartPress(){

//         int WaitTime = GenTime.Next(1,6);

//         Waiting = true;
//         yield return new WaitForSeconds(WaitTime);
//         Waiting = false;

//         SpamBall SpamBall = GameObject.Find("Player 1").GetComponent<SpamBall>();
//         SpamBall.PressText.text = "";

//         GO.gameObject.SetActive(true);
//         SpamBall.SpamOn = true;
//         SpamBall.PressFirstOn = true;
        
//         yield return new WaitForSeconds(2.5f);
//         GO.gameObject.SetActive(false);

//     }
//     // Update is called once per frame
//     void Update()
//     {
        

//         SpamBall SpamBall = GameObject.Find("Player 1").GetComponent<SpamBall>();
        
//         if (Input.GetKeyDown(KeyCode.Space)){
//             StartCoroutine(StartPress());

//            // Player1_Movement P1Movement = GameObject.Find("Player 1").GetComponent<Player1_Movement>();
//             //P1Movement.P1Moving = true;

//             //Player2_Movement P2Movement = GameObject.Find("Player 2").GetComponent<Player2_Movement>();
//             //P2Movement.P2Moving = true;
//         }
    
    
            
         

        
        
//     }
// }
