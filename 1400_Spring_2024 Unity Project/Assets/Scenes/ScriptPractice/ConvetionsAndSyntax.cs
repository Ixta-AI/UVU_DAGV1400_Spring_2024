using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {//dot opporator seperate and access elements
        Debug.Log(transform.position.x);
        
        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }//dot (.) opporator full stop (one word DOT second word)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//indentation makes for easy to read and follow code
/* comment syntax 
 * that lets you type out multiple lines*/