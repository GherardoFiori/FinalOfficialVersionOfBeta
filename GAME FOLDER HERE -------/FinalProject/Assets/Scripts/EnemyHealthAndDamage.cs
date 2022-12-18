using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthAndDamage : MonoBehaviour
{
    public float ghoulHealth = 100f;
    public float arrowDamage = 25f;
    public AudioClip deathSound; // placeholder for death sound



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "arrow")
        {
            ghoulHealth = ghoulHealth - arrowDamage;// if arrow hits the ghoul damage is taken
        }
        if (ghoulHealth <= 0)
        {
            ScoreScript.scoreValue += 1;// adding value to the score  in ScoreScript
            // play death sound
            if (deathSound != null)
            {
                AudioSource.PlayClipAtPoint(deathSound, transform.position);// audio of dying Ghoul
            }
            Destroy(gameObject);//Destroy the ghoul
        }
    }
}
