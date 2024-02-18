using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementsPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       /*When the floating points are in the start block
        the code does not interact with the update function
       so I need to write the floating point variables just before the
       update branch.*/
    }
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        
        coffeeTemperature -= Time.deltaTime * 5f;
        
    }
    void TemperatureTest() 
    { 
        if(coffeeTemperature > hotLimitTemperature) 
        {
            print("Coffee is too hot.");
        }
        else if(coffeeTemperature < coldLimitTemperature) 
        {
            print("Coffee is too cold.");
        }
        else 
        {
            print("Coffee is just right.");
        }
    }
}
