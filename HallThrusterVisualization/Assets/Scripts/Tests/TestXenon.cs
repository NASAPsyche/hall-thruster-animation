using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestXenonMove
    {
        private ReleaseXenon releaseXenon;
        private Oscillator oscillator;
        // A Test behaves as an ordinary method
        // [Test]
        // public void XenonValueOfY()
        // {
        //   GameObject xenonObject = MonoBehaviour.Instantiate(Resources.Load ("Xenon") as GameObject);
        //   releaseXenon = xenonObject.GetComponent<ReleaseXenon>();
        //   Vector3 test = releaseXenon.riseXenon();

        //   float curYVal = xenonObject.transform.position.y;
        //   if(curYVal<=.2){
        //       curYVal+=Time.deltaTime/1.5f;
        //   }

        //   Assert.AreEqual(curYVal, test.y);
        // }

        // [Test]
        // public void OnCollisionXenonIonizes(){
        //   //make the xenon collide with an electron and check if the collision function is called
        //   GameObject electronObject = MonoBehaviour.Instantiate(Resources.Load ("electron") as GameObject);
        //   oscillator = electronObject.GetComponent<Oscillator>();
        //   Vector3 xenon = oscillator.OnCollisionEnter(null);

        //   GameObject xenonObject = MonoBehaviour.Instantiate(Resources.Load ("Xenon") as GameObject);


        //   Assert.AreEqual(electronObject.transform.position.y, xenon.y);
        // }
    }

}
