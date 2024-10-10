using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Movement : MonoBehaviour
{

    //Moves player 1 (left side of board)
    public float speed = 1;
    Vector2 velocity;
    public bool P1Moving = true;
    public GameObject HitPaddle;
    // Update is called once per frame
    void Update()
    {
        
        if (P1Moving == true){
        Vector2 input = new Vector2(0, Input.GetAxisRaw("Vertical"));
        Vector2 direction = input.normalized;
        velocity = direction*speed*Time.deltaTime;
        
        if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S)){ //Moves Player 1 paddle up or down if W or S is pressed
            transform.position = ((Vector2)transform.position + velocity);
        }
        
        
        Hit();
        
        }
        
        // if(Input.GetKey(KeyCode.D)){
        //     HitPaddle.gameObject.SetActive(true);
        //     HitMechanic HitMechanic = GameObject.Find("Player 1").GetComponent<HitMechanic>();
        //     StartCoroutine(HitMechanic.HitBall1());
            
        //  }
    }

    public void Hit(){
        if (P1Moving == true){
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        Vector2 direction = input.normalized;
        velocity = direction*speed*Time.deltaTime;

        if(Input.GetKey(KeyCode.D)){ //Moves Player 1 paddle up or down if W or S is pressed
            transform.position = ((Vector2)transform.position + velocity);
        }

        }
        
        // if(Input.GetKey(KeyCode.D)){
        //     HitPaddle.gameObject.SetActive(true);
        //     HitMechanic HitMechanic = GameObject.Find("Player 1").GetComponent<HitMechanic>();
        //     StartCoroutine(HitMechanic.HitBall1());
            
        //  }
    }
    

}
