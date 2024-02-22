using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatPractice : MonoBehaviour
{// In game form id assume a script that ++ triggers every time a level is increased
    public int intelligence = 5;

    void Greet() 
    {//fallout Int tree or most RPG functions
        switch (intelligence) 
        {
            case 5:
                print("Why hello there good sir! Let me teach you about Trigono..zzzzz");
                break;
            case 4:
                print("Hello and good day!");
                break;
            case 3:
                print("whadya want");
                break;
            case 2:
                print("Grog Smash");
                break;
            case 1:
                print("Ulg, glin, duba da I am the glib blob dub dub bud");
                break;
            default:
                print("Incorrect intelligence level");
                break;
        }
    }
}
