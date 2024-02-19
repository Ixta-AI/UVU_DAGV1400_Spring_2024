using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoopPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {// declaring an array and assigning a total of 3 index/elements for it
        string[] strings = new string[3];
     //index one assigning element string value "first string"   
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";
//for every item(index) in the array "strings" write out what it says
        foreach (string item in strings) 
        { 
            print(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
