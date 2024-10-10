using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    
    public void HandleInputData(int val){

        if (val == 0){
            QualitySettings.SetQualityLevel(0, true);
        }

        if (val == 1){
            QualitySettings.SetQualityLevel(2, true);
        }

        if (val == 2){
            QualitySettings.SetQualityLevel(3, true);
        }

        if (val == 3){
            QualitySettings.SetQualityLevel(5, true);
        }
    }

    //Aug. 9th @ 2:58AM - Volume slider https://docs.unity3d.com/ScriptReference/AudioSource-volume.html
}
