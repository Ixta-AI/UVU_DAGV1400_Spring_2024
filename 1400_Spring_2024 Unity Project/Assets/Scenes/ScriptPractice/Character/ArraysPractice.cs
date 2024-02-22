using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysPractice : MonoBehaviour
{
    public GameObject[] players;

    // Start is called before the first frame update
    void Start()
    {//this will track players (players contain the tag player)
        players = GameObject.FindGameObjectsWithTag("Player");
        //this code will list and name each player
        for(int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number " + i + " is named" + players[i].name); 
        }
    }//this code will show index instead of numbers so you would start at 0
    //to use regular numbers we can do simple arithmetic on the array increasing it by one before its read
    //it would look somehting like (i + 1) making the 0 a one while still starting at index 0

}
//arrays store data of the same type together: An array is not a type it is a collection of variable of a certain type (int, string)
/*There are more then one way to creat arrays
 you can do it one by one or in a array list
Making an array public lets us see it in the inspector of unitys engine*/