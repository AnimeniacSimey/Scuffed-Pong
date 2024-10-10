using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HitMechanic : MonoBehaviour
{
    
    public GameObject HitPaddle;
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    public IEnumerator HitBall1()
    {
       
        Player1_Movement P1Movement = GameObject.Find("Player 1").GetComponent<Player1_Movement>();
        P1Movement.P1Moving = false;
        Debug.Log("1 false");
        HitPaddle.transform.position = P1Movement.transform.position + new Vector3(0.3f,0,0);
        yield return new WaitForSeconds(0.5f);
        P1Movement.P1Moving = true;
        HitPaddle.gameObject.SetActive(false);
    }

    public IEnumerator HitBall2()
    {
        
        Player2_Movement P2Movement = GameObject.Find("Player 2").GetComponent<Player2_Movement>();
        P2Movement.P2Moving = false;
        Debug.Log("2 false");
        HitPaddle.transform.position = P2Movement.transform.position + new Vector3(-0.3f,0,0);
        yield return new WaitForSeconds(0.5f);
        P2Movement.P2Moving = true;
        HitPaddle.gameObject.SetActive(false);
    }

    
}
