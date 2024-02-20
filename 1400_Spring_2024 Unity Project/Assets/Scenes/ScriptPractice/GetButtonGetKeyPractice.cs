using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetButtonGetKeyPractice : MonoBehaviour
{
    public Image graphic;
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;


    // Start is called before the first frame update
    void Start()
    {
        graphic.sprite = standard;
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonDown("Jump");

        if(down)
        {
            graphic.sprite = downgfx;
        }
        else if(held) 
        {
            graphic.sprite = heldgfx;
        }
        //else if(up) 
       // {
            //graphic = upgfx;
       // }
        else 
        {
            graphic.sprite = standard;
        }

        
    }
}
//example code given seems to be out of date and does not function in unity