using System;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text timerText;
    public float startTime;
    void Start()
    {
        startTime = Time.time;
    }
    void Update()
    {
        float t = Time.time - startTime;
        string seconds;
        string minutes = ((int)t / 60).ToString();
        string time = (t % 60).ToString("f0");
        if (int.Parse(time) == 60)
        {
            seconds = "00";
            minutes = (((int)t / 60) + 1).ToString();
        }
        else if ((t % 60).ToString("f0").Length >= 2) { seconds = (t % 60).ToString("f0"); }
        else
        {
            seconds = "0" + (t % 60).ToString("f0");
        }


        timerText.text = minutes + ":" + seconds;
    }

}
