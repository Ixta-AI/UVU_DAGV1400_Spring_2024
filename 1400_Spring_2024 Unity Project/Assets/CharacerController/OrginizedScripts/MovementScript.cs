using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float movementSpeed = 1;
    public float jumpPower = 10f;

    //Earths Gravity is 9.81 and a positive in unity means up so the negative is for downward force
    public float gravityForce = -9.81f;
   //storing the value of our y axis
    public float currentVelY =0;

    public bool isSprinting = false;
    public float sprintingMultiplier;

    public bool isCrouching = false;
    public float crouchingMultiplier;

    public CharacterController controller;
    public float standingHeight = 1.9f;
    public float crouchingHeight = 1.25f;

    public LayerMask groundMask;
    public Transform groundDetectionTransform;

    public bool isGrounded;

    public void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    public void CheckIsGrounded() 
    {
        Collider[] cols = Physics.OverlapSphere(groundDetectionTransform.position,0.05f, groundMask);

        if(cols.Length > 0 )
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
    public void Update()
    {//Player movement taking in X-Axis input and Y-Axis input
        float inputXAxis = Input.GetAxis("Horizontal");
        float inputYAxis = Input.GetAxis("Vertical");
        CheckIsGrounded();
        //Cant get player jump working. (Removing Rigid body stoped it from lifting up but the code seems to stop my movement all together)
        /*  if (isGrounded == false)
          {
              currentVelY += gravityForce * Time.deltaTime;
          }
          else if (isGrounded == true)
          {
              currentVelY = -2f;
          }
          if (Input.GetKeyDown("Space") && isGrounded == true)
          {
              currentVelY = jumpPower;
          }
          Debug.Log(isGrounded);*/
//button check for sprint input
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        else
        {
            isSprinting = false;
        }

        Vector3 movement = new Vector3();
        
        movement = inputXAxis * transform.right + inputYAxis * transform.forward;
        //crouching key check
        if (Input.GetKey(KeyCode.LeftControl))
        {
            isCrouching = true;
        }
        else
        {
            isCrouching= false;
        }
        //Crouching applied here

        if (isCrouching == true)
        {
            controller.height = crouchingHeight;
        }
        else
        {
            controller.height = standingHeight;
        }
//Sprint multiplier is applied to movement
        if (isSprinting == true)
        {
            movement *= sprintingMultiplier;
        }

//Using stored X and Y values to move character by combining the two and multipling by movementSpeed and Time.deltaTime(to have non frame dependent movement)
        controller.Move(movement * movementSpeed * Time.deltaTime);
        
//Gravity controll
        controller.Move(new Vector3(0, currentVelY * Time.deltaTime, 0));

    }
}
