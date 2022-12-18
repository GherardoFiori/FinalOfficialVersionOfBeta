using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Toggle fullscreenTog;

    void Start ()
    {
        fullscreenTog.isOn = Screen.fullScreen; // start the game with full screen
    }
    
    void Update ()
    {

    }

    public void ApplyGraphics()
    {
        Screen.fullScreen = fullscreenTog.isOn;
    }
}
