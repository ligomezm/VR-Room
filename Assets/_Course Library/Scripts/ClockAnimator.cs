using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour
{
    private const float
        hoursToDegrees = 360f / 12f,
        minutesToDegrees = 360f / 60f,
        secondsToDegrees = 360f / 60f;

    public Transform hours, minutes, seconds;

    public bool analog;

    private void Update()
    {
        if (analog)
        {
            TimeSpan timeSpan = DateTime.Now.TimeOfDay;
            hours.localRotation = Quaternion.Euler((float)timeSpan.TotalHours * hoursToDegrees, 0f, 0f);
            minutes.localRotation = Quaternion.Euler((float)timeSpan.TotalMinutes * minutesToDegrees, 0f, 0f);
            seconds.localRotation = Quaternion.Euler((float)timeSpan.TotalSeconds * secondsToDegrees, 0f, 0f);
        }
        else { 
            DateTime time = DateTime.Now;
            hours.localRotation = Quaternion.Euler(time.Hour * hoursToDegrees, 0f, 0f);
            minutes.localRotation = Quaternion.Euler(time.Minute * minutesToDegrees, 0f, 0f);
            seconds.localRotation = Quaternion.Euler(time.Second * secondsToDegrees, 0f, 0f);
        }
        
    }
}
