﻿using System;
using UnityEngine;

public class Clock : MonoBehaviour {

    const float
    degreesPerHour = 30f,
        degreesPerMinute = 6f,
        degreesPerSecond = 6f;

    public Transform hoursTransform, minutesTransform, secondsTransform;
    public bool continuous;

    void UpdateContinuous () {
        TimeSpan time = DateTime.Now.TimeOfDay;

        Debug.Log (time.TotalHours);
        hoursTransform.localRotation =
            Quaternion.Euler (0f, (float) time.TotalHours * degreesPerHour, 0f);
        minutesTransform.localRotation =
            Quaternion.Euler (0f, (float) time.TotalMinutes * degreesPerMinute, 0f);
        secondsTransform.localRotation =
            Quaternion.Euler (0f, (float) time.TotalSeconds * degreesPerSecond, 0f);
    }

    void UpdateDiscrete () {
        DateTime time = DateTime.Now;
        Debug.Log (time.Hour);
        hoursTransform.localRotation =
            Quaternion.Euler (0f, time.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation =
            Quaternion.Euler (0f, time.Minute * degreesPerMinute, 0f);
        secondsTransform.localRotation =
            Quaternion.Euler (0f, time.Second * degreesPerSecond, 0f);
    }

    void Update () {
        if (continuous) {
            UpdateContinuous ();
        } else {
            UpdateDiscrete ();
        }
    }
}