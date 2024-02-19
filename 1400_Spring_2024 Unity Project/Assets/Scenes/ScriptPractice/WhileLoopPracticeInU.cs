using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoopPracticeInU : MonoBehaviour
{//initilization of variable integer named cupsInTheSink assigned value of 4
    int cupsInTheSink = 4;
    // Start is called before the first frame update
    void Start()
    {
        while(cupsInTheSink > 0) 
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
         /*while there are cups in the sink
          wash a cup and place it to dry.
         -- "While" Condition 4 is greater than 0
         Write washed and reduce the amount of cups
         by one then check condition and repeat 
         while true*/
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
