using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//need to fix electrons movement
public class Oscillator : MonoBehaviour
{
    public float timeCounter = 0;
    private bool beginAnimation = false;
    private Animation anim;

    // Start is called before the first frame update
    public void Start()
    {
      this.gameObject.SetActive(false);
      timeCounter=transform.position.x*30f;
      timeCounter+=transform.position.z*20f;
    }

    public void SetActiveTrue(){
      this.gameObject.SetActive(true);
      anim = this.gameObject.GetComponent<Animation>();
      string electronName = this.gameObject.name;
      char electronNumAnimation = ' ';
      // getting the number of electron to play the animation
      for(int i = electronName.Length - 1; i>=0; i--)
      {
        if(electronName[i] >= 48 && electronName[i] <= 57){
          electronNumAnimation = electronName[i];
        }
      }
      anim.Play("e" + electronNumAnimation + "cathode");
      StartCoroutine("DisableScript");


    }

    public void resetAnim(){
      this.gameObject.SetActive(false);
    }

    private IEnumerator DisableScript()
    {
        yield return new WaitForSeconds(1f);
        beginAnimation = true;
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

    // oscillating electrons around the chamber
    public Vector3 MoveElectron(){
        timeCounter += Time.deltaTime;
        float R = 1/1.7f + Mathf.Cos(5*timeCounter)/17f;
        float Rz = Mathf.Cos(timeCounter/8)/17f;
        float x = R*Mathf.Cos(timeCounter*2);
        float z = R*Mathf.Sin(timeCounter*2);
        float y=0;
        return new Vector3 (x,y,z);
    }

    public Vector3 OnCollisionEnter(Collision collision)
    {
      return new Vector3();
    }
}
