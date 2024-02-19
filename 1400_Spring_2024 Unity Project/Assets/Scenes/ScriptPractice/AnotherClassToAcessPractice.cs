using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClassToAcessPractice : MonoBehaviour
{//will be accessable if I creat another instance of this class (if I creat an access object)
    public int apples;
    public int bananas;

//will not be accessable due to being private
    private int stapler;
    private int sellotape;
 
    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: "+ answer);
    }

 //will not be accessable due to being private
   private void OfficeSort (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: "+ answer);
    }
}
