using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewPlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float jumpForce = 200f;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float turnSpeed = 10;
    private Vector3 MoveDirection = Vector3.zero;
    // Start is called before the first frame update
    public CharacterController PlayerHeight;
    [SerializeField] private float normalHeight, crouchHeight;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//player movement                        X-Axis     Y-Axis   Z-Axis  
        var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

//Taking in object Direction Multiplied by speed and Multiplied by Time.DeltaTime
        transform.Translate(dir * speed * Time.deltaTime);

//Adding RigidBody interaction
        rb.velocity = dir * speed;

//Adding rotation  (this is care/tank movement and it messses with the capsle movement)                     
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime);

        //adding crouch (doesent work)
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            PlayerHeight.height = crouchHeight;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl)) 
        {
            PlayerHeight.height = normalHeight;
        }

//Attempting to add a jump but does not work
      if(Input.GetButton("Jump"))
            MoveDirection.y = jumpForce;
        
        /* var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed;
        vel.y = rb.velocity.y;
        rb.velocity = vel;

        if (Input.GetKeyDown(KeyCode.Escape)) 
           rb.AddForce(Vector3.up * jumpForce);*/
    }
}
//Found out why my object was falling up: Gravity was set to 9.80 which had it shoot upwards
//Still Gravity affects player movement in a strange way when -9.80 playr movement increases strangly
//"Is Kinematic stops these physics issues from happening when on.
//I think the flying is being caused by colliders overlapin on the capsule
//I assigned the player to the rmpty rigid body and that stoped the flying
//Gravity acts werid now It slowly lowers the player and Jump does not function