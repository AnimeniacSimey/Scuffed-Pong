using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Movement : MonoBehaviour
{
    //Moves player 2 (right side of board)
    public float speed = 1;
    Vector2 velocity;
    public bool P2Moving = true;
    public GameObject HitPaddle;
    // Update is called once per frame
    void Update()
    {
        while(P2Moving == true){
        Vector2 input = new Vector2(0, Input.GetAxisRaw("Player2Vert"));
        Vector2 direction = input.normalized;
        velocity = direction*speed*Time.deltaTime;
        
        if (Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.DownArrow)){ //Moves Player 2 paddle if Up Arrow or Down Arrow is pressed
            transform.position = ((Vector2)transform.position + velocity);
        }
        break;
        }
        
       if(Input.GetKey(KeyCode.LeftArrow)){
            HitPaddle.gameObject.SetActive(true);
            HitMechanic HitMechanic = GameObject.Find("Player 2").GetComponent<HitMechanic>();
            StartCoroutine(HitMechanic.HitBall2());
            
         }
    }

    
}
