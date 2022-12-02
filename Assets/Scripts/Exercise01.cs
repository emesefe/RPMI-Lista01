using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    public float num1 = 10;
    public float num2 = 5;
    public float num3 = 1;

    public float sum;

    private void Start()
    {
        // We store the value of the sum of num1, num2 and num3 in sum
        sum = num1 + num2 + num3;
        Debug.Log($"The sum of {num1} + {num2} + {num3} = {sum}");
    }
}
