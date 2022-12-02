using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise07 : MonoBehaviour
{
    public string letter;

    private void Start()
    {
        /* The conditions in order for a letter to be a vowel are:
         * letter == "a"
         * letter == "e"
         * letter == "i"
         * letter == "o"
         * letter == "u"
         * we only need one of them to be true for all of them to be true, so we use the operator OR
         */
        
        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {
            Debug.Log($"This letter, {letter}, is a vowel.");
        }
        else
        {
            Debug.Log($"This letter, {letter}, is a consonant.");
        }
    }
}
