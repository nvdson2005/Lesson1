using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class YourScoreScript : MonoBehaviour
{
    [SerializeField] TMP_Text YourScoreText;
    // Start is called before the first frame update
    void Start()
    {
        YourScoreText.fontSize = 25.47f;
        if(PlayerPrefs.GetFloat("ScoreFloat") > PlayerPrefs.GetFloat("HighScoreFloat", 0f))
        {
            YourScoreText.text = PlayerPrefs.GetString("Score") + "   (New High Score!)";
            PlayerPrefs.SetFloat("HighScoreFloat", PlayerPrefs.GetFloat("ScoreFloat"));
        }  else
        {
            YourScoreText.text = PlayerPrefs.GetString("Score") + " (High Score: " + Mathf.Round(PlayerPrefs.GetFloat("HighScoreFloat", 0f)).ToString() + ")";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
