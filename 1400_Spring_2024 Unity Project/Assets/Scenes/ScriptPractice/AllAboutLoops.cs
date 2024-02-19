using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllAboutLoops : MonoBehaviour
{//Declaired and initilized var integer.
    int numEnemies = 3;
    // Start is called before the first frame update
    void Start()
    {//For Loop
        for(int i = 0; i < numEnemies; i++) 
        {//initilize declared integer named i with a value of 0
            //check if variable i is less then numEnemies(3)
                //Write Creating enemy number then incriment i by one
            //check if variable i is less then numEnemies(3)
            Debug.Log("Creating enemy number: " + i);
        }
    }// the loop will loop 3 times

    // Update is called once per frame
    void Update()
    {
        
    }
}
