using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintScript : MonoBehaviour
{
    public bool isSprinting = false;
    public float sprintMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            isSprinting = true;
        }
        else
        {
            isSprinting = false;
        }
    }
}
