using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSleep : MonoBehaviour
{
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
