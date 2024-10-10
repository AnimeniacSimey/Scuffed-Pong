using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnClick(){ //Actions occur when button is clicked
        SceneManager.LoadScene("Classic"); //Loads gameplay scene
    }

}
