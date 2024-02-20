using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAtPractice : MonoBehaviour
{
 // tracks other Transform in world
    public Transform target;

    // Update is called once per frame
    void Update()
    {//looks at the target (we can drag target object into target field)
        transform.LookAt(target);   
    }
}
//camera tracking (not follow just track)