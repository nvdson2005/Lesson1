using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] GameObject gameObj1, gameObj2, gameObj3, gameObj4;
    public float timeCount = 0f;
    public TMP_Text timer;
    // Start is called before the first frame update
    void Start()
    {
        timer.text = "";
        timer.fontSize = 45;
        timer.fontStyle = FontStyles.Bold;
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = Mathf.Round(timeCount).ToString();
        PlayerPrefs.SetString("Score", timer.text);
        PlayerPrefs.SetFloat("ScoreFloat", timeCount);
        timeCount += Time.deltaTime;
        if(timeCount > 30f)
        {
            gameObj1.SetActive(true);
            gameObj2.SetActive(true);
        }
        if(timeCount > 60f)
        {
            gameObj3.SetActive(true);
            gameObj4.SetActive(true);
        }
    }
}
