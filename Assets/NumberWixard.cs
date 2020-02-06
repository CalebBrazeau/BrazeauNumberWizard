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

        //Talking to user
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
        //Input From player for up arrow key
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //prints this when player presses up arrow key
            Debug.Log("Up arrow key was pressed");
        }
        //Input from player for down key
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //prints this when player presses Down arrow key
            Debug.Log("Down arrow key was pressed");
        }
        //Input from player for Enter Key
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //prints this when player presses Enter Key
            Debug.Log("Enter key was pressed");
        }
    }
}
