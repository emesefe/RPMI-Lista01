using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise06 : MonoBehaviour
{
    public int dayOfWeek = 1;

    private void Start()
    {
        // We have already been told that only values between 1 and 7 inclusive will be passed.
        if (dayOfWeek <= 5)
        {
            Debug.Log($"Day {dayOfWeek} does not belong to the weekend");
        }
        else
        {
            Debug.Log($"Day {dayOfWeek} belongs to the weekend");
        }
    }

   
}
