using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWixard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //max Number Variable
        int intMaxNumber = 4;
        //Min Number Variable
        int intMinNumber = 1;

        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number, do not tell me what it is");
        Debug.Log("The highest number you can pick is: " + intMaxNumber);
        Debug.Log("The lowest number you can pick is: " + intMinNumber);
        Debug.Log("Tell me if your number is higher or lower than 4");
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
