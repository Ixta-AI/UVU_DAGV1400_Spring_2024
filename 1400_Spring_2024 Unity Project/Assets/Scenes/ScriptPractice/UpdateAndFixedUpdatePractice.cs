using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdatePractice : MonoBehaviour
{
    //Created using the CTRL + SHIFT + M Wizard shortcut
    /*private void LateUpdate()
    {

    }

    private void OnMouseUpAsButton()
    {

    }*/
    //can help avoid errors
    private void FixedUpdate()//Called on regular time line
    {
        //Called every physics step (Determined by Unity physics engine with a default of 50 times a second or 0.02)
        //Used for physics-related calculations (Example: Simulation for gravity on moving objects)
        //Adjusting physics for Ridgidbody objects
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
    // Update is called once per frame
    void Update()//Not called on a regular time line. Funny SO FALOUT movement is tied to FPS because of this.
    {
       //Used for regular updates
       //Simple Timers (is there a more advanced timer?)
       //Receiving Input (So player movement Id assume)
       //Moving non-physics objects(I assume objects with physics move on their own without the need for frame updates)
       /*I assume most movement goes here Some effects like DOT modifiers 
        *and some world updates like moving tarrain*/
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
/*VS short cut (MONO behavior Scripting Wizard)
 Place cursure where you want the new function to be
Then Press CTRL+SHIFT+M to launch the wizard 
Mark the chck box net to the name of each method you want to add.
Looks like you can only do it in the main block of code (does not work out here)*/