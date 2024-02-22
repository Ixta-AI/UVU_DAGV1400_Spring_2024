using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed = 5f;
    public float turnSpeed = 30f;

    public float WalkSpeed = 5f;
    private float sprintSpeed = 10f;
    public float gravity = 9.81f;
    public float jumpSpeed;
    public float jumpForce = 2f;
    private bool isGrounded;

    private float ySpeed;
    private CharacterController controller;
    private Vector3 moveDirection;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {// Movement
       
       float horizontalInput = Input.GetAxis("Horizontal") * moveSpeed;
       float verticalInput = Input.GetAxis("Vertical") * moveSpeed;

        rb.velocity = new Vector3(horizontalInput, 0, verticalInput);

        Vector3 moveDirectionForward = transform.forward * verticalInput;
        Vector3 moveDirectionSideways = transform.right * horizontalInput;
        moveDirection = (moveDirectionForward + moveDirectionSideways).normalized * moveSpeed;
        controller.Move(moveDirection * Time.deltaTime * moveSpeed);
       
        //turn character using arrow
      
        //sprint
        if (Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            moveSpeed = sprintSpeed;
        }
        else
        {
            moveSpeed = WalkSpeed;
        }

        /*    void Update()
    {// Movement

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3 (horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * moveSpeed * Time.deltaTime, Space.World);

        if(movementDirection != Vector3.zero) 
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection,Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, turnSpeed * Time.deltaTime);
        }
    }
         */
    }

}

//So far every time I try to add Jump it does nothing and when I switch to the example code in the multiLine comment all that happens is my Object falls upwords. 