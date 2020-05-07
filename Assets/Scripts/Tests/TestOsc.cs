using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestOsc
    {
      private Oscillator oscillator;
        //private electron elec;
        [Test]
       public void electronsMoveX(){
           GameObject electonObject = MonoBehaviour.Instantiate(Resources.Load ("electron") as GameObject);
           oscillator = electonObject.GetComponent<Oscillator>();

           Vector3 test = oscillator.MoveElectron();

           float timeCounter = oscillator.getTimeCounter();
           float R = 1/1.7f + Mathf.Cos(5*timeCounter)/17f;
           float x = R*Mathf.Cos(timeCounter/8);


           Debug.Log(test.x);
           Debug.Log(x);
           Assert.AreEqual(x, test.x);
       }
       [Test]
       public void electronsMoveZ()
       {
         GameObject electonObject = MonoBehaviour.Instantiate(Resources.Load ("electron") as GameObject);
         oscillator = electonObject.GetComponent<Oscillator>();

         Vector3 test = oscillator.MoveElectron();

         float timeCounter = oscillator.getTimeCounter();
         float R = 1/1.7f + Mathf.Cos(5*timeCounter)/17f;
         float z = R*Mathf.Sin(timeCounter/8);


         Debug.Log(test.z);
         Debug.Log(z);
         Assert.AreEqual(z, test.z);
       }

       [Test]
       public void electronsDontMoveY()
       {
         GameObject electonObject = MonoBehaviour.Instantiate(Resources.Load ("electron") as GameObject);
         oscillator = electonObject.GetComponent<Oscillator>();

         float zero = 0.0f;
         Vector3 test = oscillator.MoveElectron();

         Assert.AreEqual(zero, test.y);
       }
    }
}
