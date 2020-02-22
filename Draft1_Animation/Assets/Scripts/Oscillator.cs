﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oscillator : MonoBehaviour
{
    float timeCounter = 0;
    bool beginAnimation = false;
    // Start is called before the first frame update
    public void Start()
    {
      timeCounter=transform.position.x*30f;
      timeCounter=transform.position.z*20f;
    }

    public void callUpdate()
    {
      //if(Input.GetKeyDown(KeyCode.Space))
      beginAnimation = true;
    }

    // Update is called once per frame
    public void Update()
    {
        //Debug.Log("Update" + beginAnimation);
        // Check for space input and set boolean to opposite

        //only change electrons when begin animation is true

    }

    public void LateUpdate()
    {
      if(beginAnimation)
      {
         transform.position = MoveElectron();
      }
    }

    public float getTimeCounter()
    {
      return timeCounter;
    }


    public Vector3 MoveElectron(){
        timeCounter += Time.deltaTime;
        float R = 1/1.7f + Mathf.Cos(5*timeCounter)/17f;
        float Rz = Mathf.Cos(timeCounter/8)/17f;
        //timeCounter += transform.position.x;
        float x = R*Mathf.Cos(timeCounter*2);
        float z = R*Mathf.Sin(timeCounter*2);
        float y=0;
        //float y = Rz*Mathf.Cos(5*timeCounter)/17f;
        return new Vector3 (x,y,z);
    }

    public Vector3 OnCollisionEnter(Collision collision)
    {
      return new Vector3();
    }
}
