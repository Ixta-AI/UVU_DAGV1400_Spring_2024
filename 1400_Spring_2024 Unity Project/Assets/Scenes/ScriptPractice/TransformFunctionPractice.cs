using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunctionPractice : MonoBehaviour
{//coutome variables used to change the speed 
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    // Update is called once per frame
    void Update()
    {//Delta time converts movement from every frame to m/sec
        if(Input.GetKeyDown(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.Translate(Vector3.forward * -turnSpeed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.Translate(Vector3.forward * turnSpeed * Time.deltaTime);
    }
}
//.forward is shortcut for vectore3(0, 0, 1)
//because the variables are public we can eddit there values in the game engine