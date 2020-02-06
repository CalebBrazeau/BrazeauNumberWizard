using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWixard : MonoBehaviour {

    //max Number Variable
    int intMaxNumber = 10;
     //Min Number Variable
    int intMinNumber = 1;
    //Player guess
    int intGuess = 5;
    // Start is called before the first frame update
    
    void Start()
    {
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
            //Changes minimun number to the players guess
            intMinNumber = intGuess;
            Debug.Log(intGuess);
        }
        //Input from player for down key
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //prints this when player presses Down arrow key
            Debug.Log("Down arrow key was pressed");
            //Changes Maximum number to players guess
            intMaxNumber = intGuess;
            Debug.Log(intGuess);
        }
        //Input from player for Enter Key
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //prints this when player presses Enter Key
            Debug.Log("Enter key was pressed");
        }
    }
}