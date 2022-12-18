using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    void Start() {
        Cursor.lockState = CursorLockMode.None; Cursor.visible = true;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Level_1");// once dead option to restart on level 1 is available 
    } 

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu_1");// or the option to go back to main menu 
    }  
}
