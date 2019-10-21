using System;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text timerText;
    public float startTime;
    public static string endMinutes;
    public static string endSeconds;
    void Start()
    {
        startTime = Time.time;
    }
    void Update()
    {
        float t = Time.time - startTime;
        string seconds;
        string minutes = ((int)t / 60).ToString();
        endMinutes = minutes;
        string time = (t % 60).ToString("f0");
        if (int.Parse(time) == 60)
        {
            seconds = "00";
            endSeconds = seconds;
            minutes = (((int)t / 60) + 1).ToString();
            endMinutes = minutes;

        }
        else if ((t % 60).ToString("f0").Length >= 2) {
            seconds = (t % 60).ToString("f0");
            endSeconds = seconds;
        }
        else
        {
            seconds = "0" + (t % 60).ToString("f0");
            endSeconds = seconds;
        }
        timerText.text = minutes + ":" + seconds;
    }

}
