using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // check if the collider that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("WinMenu");// Load up the end game screen once level 2 door is reached
        }
    }
}
