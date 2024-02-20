using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAndDisableCompPractice : MonoBehaviour
{//Private accessor meaning it only works here/accessable here
    private Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {//update waiting for key press
        if(Input.GetKeyDown(KeyCode.Space)) 
        { //Set to toggle by simply switching it to !(not)myLight.enabled
            myLight.enabled = !myLight.enabled;
        }//Oh lol the tutorial called it "not" as well.
        //basically saying set myLight.enabled to what its not every press of space.
    }
}
