using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timer = 5;
    public Text timeText;

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = 0; //so it doesn't go into the negatives
        }

        timeRemaining(timer);

    }

    void timeRemaining (float displayTime)
    {
        if (displayTime < 0)
        {
            displayTime = 0;
            SceneManager.LoadScene("Lose");
        }

        float min = Mathf.FloorToInt(displayTime / 60);
        float sec = Mathf.FloorToInt(displayTime % 60);

        timeText.text = string.Format("{0:00}:{1:00}", min, sec);
    }

    
}
