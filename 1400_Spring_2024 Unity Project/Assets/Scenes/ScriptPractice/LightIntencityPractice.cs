using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntencityPractice : MonoBehaviour
{
    public float smooth = 2;
    private float newIntensity;

    void Awake ()
    {
        newIntensity = GetComponent<Light>().intensity;
    }

    // Update is called once per frame
    void Update()
    {
        IntensityChanging();
    }

    void IntensityChanging() 
    {
        float intensityA = 0.5f;
        float intensityB = 5f;

        if(Input.GetKeyDown(KeyCode.A))
            newIntensity = intensityA;
        if(Input.GetKeyDown(KeyCode.D))
            newIntensity = intensityB;

        GetComponent<Light>().intensity = Mathf.Lerp(GetComponent<Light>().intensity, newIntensity, Time.deltaTime * smooth);
    }
}
