using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsButton : MonoBehaviour
{
    public void OnClick(){
        SceneManager.LoadScene("Options");
    }

    public void BackButton(){
        SceneManager.LoadScene("MainMenu");
    }
}
