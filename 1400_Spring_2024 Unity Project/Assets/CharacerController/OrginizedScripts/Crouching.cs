using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouching : MonoBehaviour
{
    public CharacterController PlayerHeight;
    [SerializeField] private float normalHeight, crouchHeight;

    // Update is called once per frame
    void Update()
    {
        //adding crouch
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            PlayerHeight.height = crouchHeight;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            PlayerHeight.height = normalHeight;
        }
    }
}
