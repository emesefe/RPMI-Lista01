using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise08 : MonoBehaviour
{
    public string month = "january";
    
    private void Start()
    {
        if (month == "february")
        {
            Debug.Log($"{month} has 28 days");
        }
        else if (month == "april" || month == "june" || month == "september" || month == "november")
        {
            Debug.Log($"{month} has 30 days");
        }
        else
        {
            Debug.Log($"{month} has 31 days");
        }

    }
}
