using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpPractice : MonoBehaviour
{
    public float smooth = 2;
    private Vector3 newPosition;
    void Awake()
    {
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        positionChanging();
    }
    void positionChanging() 
    {
        Vector3 positionA = new Vector3(-5, 3, 0);
        Vector3 positionB = new Vector3(5, 3, 0);
        
        if(Input.GetKey(KeyCode.Q)) 
            newPosition = positionA;
        if(Input.GetKey(KeyCode.E))
            newPosition = positionB;
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * smooth);
    }//will smothly transition between position A and position B
    //Smooth is a public variable and can be changed to change the speed at which positions are switched
}
