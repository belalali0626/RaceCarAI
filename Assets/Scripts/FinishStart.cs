using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishStart : MonoBehaviour
{
    public Text timer;
    private float startTime;
    public bool finished = false;
    public bool start = false;

    private void Update()
    {
        if (start == true && finished == false)
        {
            float t = Time.time - startTime;
            string minutes = ((int)t / 60).ToString();
            string seconds = ((t % 60).ToString());

            timer.text = minutes + ":" + seconds;
        }

    }

    public void startRace()
    {
        startTime = Time.time;
        start = true;
        timer.color = Color.green;
    }

    public void finish()
    {
        start = false;
        finished = true;
        timer.color = Color.yellow;

    }
}
