using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStartPractice : MonoBehaviour
{//"best used for setting up... references btween scripts and initialization.
//Videos Example: Enemy spawns in and is assigned an ammo count
    void Awake ()
    {
        Debug.Log("Awake called.");
    }
    // Start is called before the first frame update
    //Video Example: Allowes enemy to shoot at a defined time when theat script component is enabled
    //Ex. Like when the enemy has sight of player
    void Start()
    {
        Debug.Log("Start called.");
    }

}/*Both start and Awake will only be called once during the 
  life time of a script attached to an object; we cannont repeat
the functions by disabling and enabling a script. 
basicaly an area where initilization can occure making the code easier to read
and more org.*/
