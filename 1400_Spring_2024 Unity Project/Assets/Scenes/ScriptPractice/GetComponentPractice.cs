using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentPractice : MonoBehaviour
{
    public GameObject otherGameObject;


    private ComponentScriptOne ComponentScriptOne;
    private ComponentScriptTwo ComponentScriptTwo;
    private BoxCollider boxCol;

    private void Awake()
    {//Angle brackets are for getting a type
        ComponentScriptOne = GetComponent<ComponentScriptOne>();
        ComponentScriptTwo = otherGameObject.GetComponent<ComponentScriptTwo>();
        //GetComponent lets us get these scripts as well 
        //GetComponent is expensive in processing power so calling it rarily is prefered
        //either called on start or once when it is needed
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is " + ComponentScriptOne.playerScore);
        Debug.Log("The player has died " + ComponentScriptTwo.numberOfPlayerDeaths);
    }

    //access to other scripts and components using "GetComponent"
}
