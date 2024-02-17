using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndfunctionsPractice : MonoBehaviour
{//Declarization an integer variable named myInt and Initialized value 5
    int myInt = 5;
    // Start is called before the first frame update
    void Start()
    {//The result of the MultiplyByTwo function gets assigned to myInt
        myInt = MultiplyByTwo(myInt);
     //Deboug.Log is CWL for unitity
        Debug.Log (myInt);
    }//Coustum function taking an integer named number
    int MultiplyByTwo(int number) 
    {//Actions surounded by curly braces. The body of coustum function
        int result;//Dec of Var exclusive to this function
        result = number * 2;//assigning opporation to result
        return result;//returns result
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
