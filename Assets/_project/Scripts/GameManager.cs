using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float timer = 300;
    private bool timerON = true;
    public TextMeshProUGUI countdownTxt;
    bool goodCombinationColours;



    // Update is called once per frame
    void Update()
    {
        if (timerON)
        {
            if (timer > 0.0f) 
            {
                timer -= Time.deltaTime;       
            }
            else
            {
                timer = 0f;
                timerON= false;
            }
            timerTXT(timer);
        }
    }

    /// <summary>
    /// Calculate Minutes and Seconds from timer
    /// </summary>
    /// <param name="time">Time remaining</param>
    /// <returns>Time remaining as String to show it on screen </returns>
    public void timerTXT(float time) {

        float minutes = time / 60; 
        float seconds = time % 60;

        countdownTxt.text = string.Format("{00:00}:{00:00}", minutes, seconds);


    }
}
