using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public static int scoreValue;
    public TMP_Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<TextMeshProUGUI>(); //Taking component of text 
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score :" + scoreValue;// updating and modifying the score 
    }
}
