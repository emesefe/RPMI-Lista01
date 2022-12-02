using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    public string name = "Caillou";
    public int age = 4; 
    
    private void Start()
    {
        Debug.Log($"Hello, {name}! You are {age} years old");
    }
}
