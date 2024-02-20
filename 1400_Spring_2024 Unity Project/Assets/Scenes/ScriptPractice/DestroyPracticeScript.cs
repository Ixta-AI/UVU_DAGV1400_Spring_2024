using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPracticeScript : MonoBehaviour
{
    public GameObject other;
    // Update is called once per frame
    void Update() 
    {//Way to destroy object without destroying scripts
        if (Input.GetKeyUp(KeyCode.Space)) 
        {//Creating a public variable that we can drag objects into
            Destroy(other);
        }//acting like trash can
    }
   /*       //Can remove components instead of whole objects
    * if(Input.GetKey(KeyCode.Space))
    *   {
    *       Destroy(GetComponent<MeshRenderer>());
    *   }   //mesh is being destroyd. Object still reamains but is invisible
    */ //a num can be used in the argument creating a time delay for object/component destroy
   //----------------------------------------------------
        /* {//basic destroy
        if (Input.GetKey(KeyCode.Space)) 
        {
            Destroy(gameObject);
        }
    }*/
}
