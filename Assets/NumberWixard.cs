using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWixard : MonoBehaviour {

    //max Number Variable
    int intMaxNumber = 1000;
     //Min Number Variable
    int intMinNumber = 1;
    //Player guess
    int intGuess = 500;
    // Start is called before the first frame update
    
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        intMaxNumber = 1000;
        intMinNumber = 1;
        intGuess = 500;
        //Talking to user
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number, do not tell me what it is");
        Debug.Log("The highest number you can pick is: " + intMaxNumber);
        Debug.Log("The lowest number you can pick is: " + intMinNumber);
        Debug.Log("Tell me if your number is higher or lower than " + intGuess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
        intMaxNumber = intMaxNumber + 1;        
    }

    // Update is called once per frame
    void Update()
    {
        //Input From player for up arrow key
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Changes minimun number to the players guess
            intMinNumber = intGuess;
            NextGuess();
        }
        //Input from player for down key
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Changes Maximum number to players guess
            intMaxNumber = intGuess;
            NextGuess();
        }
        //Input from player for Enter Key
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //prints this when player presses Enter Key
            Debug.Log("I win");
            StartGame();
        }
    }
    void NextGuess()
    {

            //New guess
            intGuess = (intMaxNumber + intMinNumber) / 2;
            Debug.Log("Tell me if your number is higher or lower than " + intGuess);
    }
}