using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise04 : MonoBehaviour
{
    public int birthYear;
    public int currentYear;
    private int age;

    void Start()
    {
        // We calculate the age by subtracting the year of birth from the current year
        age = currentYear - birthYear;
        Debug.Log($"If we are in the year {currentYear} and you were born in {birthYear}, you are {age} years old.");
    }
}
