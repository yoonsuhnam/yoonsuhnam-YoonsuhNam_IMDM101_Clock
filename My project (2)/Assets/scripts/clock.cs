using UnityEngine;
using System;

public class Clock : MonoBehaviour{

    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
	Transform hoursPivot, minutesPivot, secondsPivot;

    void Update () {
        DateTime currentTime = DateTime.Now;
        TimeSpan timeOfDay = currentTime.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f,0f,hoursToDegrees*(float)timeOfDay.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f,0f,minutesToDegrees*(float)timeOfDay.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f,0f,secondsToDegrees*(float)timeOfDay.TotalSeconds);

    }

}
