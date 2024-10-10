using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{

    public float speed = 1;
    Vector2 velocity;
    public bool P1Moving = true;

    // Update is called once per frame
    void Update()
    {
       Player1_Movement P1Movement = GameObject.Find("Player 1").GetComponent<Player1_Movement>();
       transform.position = new Vector2(-13.34f, P1Movement.transform.position.y);
    }
}
