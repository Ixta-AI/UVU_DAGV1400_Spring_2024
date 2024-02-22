using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumerationspractice : MonoBehaviour
{//created constants. like Arrays they start from zero so North is holding a value of 0 east is holdin 1 and so on
    enum Direction {North, East, South, West };
    
    // Start is called before the first frame update
    void Start()
    {
        Direction myDirection;
     
        myDirection = Direction.North;
    }

    Direction ReversDirection (Direction dir) 
    {
        if(dir == Direction.North) 
            dir = Direction.South;
        else if(dir == Direction.East)
            dir = Direction.West;
        else if(dir == Direction.West)
            dir = Direction.East;

        return dir;
    }
}
//enumeration (enum) allowes for defined named constants which represent a finite list of possible values for a var
/*so we can do something like enum DayInWeek {Sunday, monday etc.} 
 This is easier to read because it provides a descripteve name for balues which makes it more self 
explanatory.

 They are type safe so you cant fill it with random values it must be one of the constants*/