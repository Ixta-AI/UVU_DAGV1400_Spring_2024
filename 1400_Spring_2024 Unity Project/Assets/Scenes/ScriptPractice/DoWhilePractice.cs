using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhilePractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {//declaring a true or false variable and assigning it false
        bool shouldContinue = false; 
        
        do //Execute this code first then check condition(s)
        {
            print("Hellow World");

        }while (shouldContinue == true);
    }//basicaly saying while our declared true/false variable remains the same
    //the same as a while loop however it executes block before checking the condition
    // Update is called once per frame
    void Update()
    {
        
    }
}
