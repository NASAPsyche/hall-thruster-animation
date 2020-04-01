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
            MagneticButton mb = GameObject.FindObjectOfType(typeof(MagneticButton)) as MagneticButton;
			mb.clicked();
        }
        if(name == "Item 2"){
            GasDispersalParticle[] gd = (GasDispersalParticle[]) GameObject.FindObjectsOfType (typeof(GasDispersalParticle));
			foreach(GasDispersalParticle element in gd){
                element.release();
            }
        }
        if(name == "Item 3"){
            ShowIonization si = GameObject.FindObjectOfType(typeof(ShowIonization)) as ShowIonization;
			si.release();
        }
        if(name == "Item 4"){
            ShowIonization si = GameObject.FindObjectOfType(typeof(ShowIonization)) as ShowIonization;
			si.resetAnim();

            GasDispersalParticle[] gd = (GasDispersalParticle[]) GameObject.FindObjectsOfType (typeof(GasDispersalParticle));
			foreach(GasDispersalParticle element in gd){
                element.resetAnim();
            }

            cathodeClicked cc = GameObject.FindObjectOfType(typeof(cathodeClicked)) as cathodeClicked;
			cc.resetAnim();

            MagneticButton mb = GameObject.FindObjectOfType(typeof(MagneticButton)) as MagneticButton;
			mb.resetAnim();
            
        }

    }
}
