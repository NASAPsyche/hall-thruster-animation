using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public void getScriptName(string name){
        
        if(name == "Item 0"){
            cathodeClicked cc = GameObject.FindObjectOfType(typeof(cathodeClicked)) as cathodeClicked;
			cc.OnMouseDown();
        }
        if(name == "Item 1"){
            MagneticButton cc = GameObject.FindObjectOfType(typeof(MagneticButton)) as MagneticButton;
			cc.clicked();
        }
        if(name == "Item 2"){
            GasDispersalParticle[] gd = (GasDispersalParticle[]) GameObject.FindObjectsOfType (typeof(GasDispersalParticle));
			foreach(GasDispersalParticle element in gd){
                element.release();

            }
        }
    }
}
