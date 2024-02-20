using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStatePractice : MonoBehaviour
{
    public GameObject myObject;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Activate Self: " +  myObject.activeSelf);
        Debug.Log("Activate in Hierarchy: " + myObject.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
