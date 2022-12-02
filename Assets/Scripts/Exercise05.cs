using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise05 : MonoBehaviour
{
    public int x = 2;
    public int y = 3;
    void Start()
    {
        if (x > y)
        {
            Debug.Log(message: $"{x} is greater than {y}");

        }
        else
        {
            Debug.Log(message: $"{y} is greater than {x}");
        }
    }
}
