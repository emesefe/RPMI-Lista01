using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise09 : MonoBehaviour
{
    public int totalCandy = 20; 
    public int people = 12;
    
    void Start()
    {
        // The amount of candy per person is the quotient of totalCandy divided by people
        // The remainder of the integer division tells us how much candy is left over after the sharing
        Debug.Log($"Each person gets {totalCandy / people} candies and there are {totalCandy % people} candies left over");
    }
}
