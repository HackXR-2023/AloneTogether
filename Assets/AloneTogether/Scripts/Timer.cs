using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    /*
       Script purpose: start a timer and on stop, trigger a callback function when stopped
    */

    private float elapsedTime = 0f;
    private bool isCounting = false;
    private float secondsToCount;
    private System.Action callback;
    public static Timer Instance;

    public Timer() { }

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (isCounting)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= secondsToCount)
            {
                if (callback != null)
                {
                    callback();
                }
                End();
            }
        }
    }
    public void StartTime(float seconds, System.Action callback)
    {
        this.secondsToCount = seconds;
        isCounting = true;
        this.callback = callback;
    }

    public void End()
    {
        isCounting = false;
        //elapsedTime = 0f;
    }

    public float GetTime()
    {
        return elapsedTime;
    }

    public int GetSecondsLeft()
    {
       return (int)(secondsToCount - elapsedTime);
    }

    public string GetTimeLeft()
    {
        int secondsLeft = (int)(secondsToCount - elapsedTime);
        return ConvertToClockTime(secondsLeft);
    }

    private string ConvertToClockTime(int seconds) 
    {
        float minute = Mathf.Floor(seconds / 60);
        string second = seconds % 60 < 10 ? "0"+seconds%60: $"{seconds%60}";
        string time = $"{minute}:{second}";
        
        return time;
    }

    public bool IsCounting()
    {
        if (isCounting)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}