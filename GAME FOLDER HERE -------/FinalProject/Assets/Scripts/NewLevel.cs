using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // check if the collider that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level_2");// load the next level
        }
    }
}
