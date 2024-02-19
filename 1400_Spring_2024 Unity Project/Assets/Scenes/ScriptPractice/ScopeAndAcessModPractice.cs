using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAcessModPractice : MonoBehaviour
{//everyhting inbetween {} is "in scope" so these variables are in scope of this class
    public int alpha = 5;
//access modifire "public, private" defines where it can be seen from
//public means it can be accessd from outside the class
//can be eddited if is public while script is running
//public int alpha value can be overwriten
    private int beta = 0;
    private int gamma = 5;
//private variables can only be edited from within the class. 
//Private is default if I do not specify otherwise in C#
    private AnotherClassToAcessPractice myOtherClass;
    void Start()
    {//this overwrites alpha from 5 to 29
        alpha = 29;
     //this alowes for access from other classes in this case a different script   
        myOtherClass = new AnotherClassToAcessPractice();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    void example (int pens, int crayons) 
    {//"in scope of the example function"
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {//everything between the brackets can be said to be a block or code blocks
        Debug.Log("Alpha is set to: " +  alpha);
    }
}
