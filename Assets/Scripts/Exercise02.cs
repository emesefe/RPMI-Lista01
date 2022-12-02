using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise02 : MonoBehaviour
{
    public string name = "Arisu";
    public string city = "Borderland";
    
    private void Start()
    {
        Debug.Log($"Hello, {name}! Welcome to {city}");
    }
}
