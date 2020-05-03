using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public void getScriptName(string name){

      if(name == "Item 1"){
          MagneticButton mb = GameObject.FindObjectOfType(typeof(MagneticButton)) as MagneticButton;

          Animation_Pointer_Magnetic apm = GameObject.FindObjectOfType(typeof(Animation_Pointer_Magnetic)) as Animation_Pointer_Magnetic;
          apm.setClicked(true);
          Animation_Pointer_Electron ape = GameObject.FindObjectOfType(typeof(Animation_Pointer_Electron)) as Animation_Pointer_Electron;
          ape.setClicked(false);

          mb.clicked();
      }
        if(name == "Item 0"){
            cathodeClicked cc = GameObject.Find("Plane.001").GetComponent<cathodeClicked>();
            // GameObject.FindObjectOfType(typeof(cathodeClicked)) as cathodeClicked;
            Animation_Pointer_Electron ape = GameObject.FindObjectOfType(typeof(Animation_Pointer_Electron)) as Animation_Pointer_Electron;
            ape.setClicked(true);
            Animation_Pointer_Gas apg = GameObject.FindObjectOfType(typeof(Animation_Pointer_Gas)) as Animation_Pointer_Gas;
            apg.setClicked(false);
            cc.OnMouseDown();
        }
        if(name == "Item 2"){
            GasDispersalParticle[] gd = (GasDispersalParticle[]) GameObject.FindObjectsOfType (typeof(GasDispersalParticle));
            Animation_Pointer_Gas apg = GameObject.FindObjectOfType(typeof(Animation_Pointer_Gas)) as Animation_Pointer_Gas;
            apg.setClicked(true);
            Animation_Pointer_Ionization api = GameObject.FindObjectOfType(typeof(Animation_Pointer_Ionization)) as Animation_Pointer_Ionization;
            api.setClicked(false);
			      foreach(GasDispersalParticle element in gd)
            {
                element.release();
            }
        }
        if(name == "Item 3"){
            ShowIonization si = GameObject.FindObjectOfType(typeof(ShowIonization)) as ShowIonization;
            Animation_Pointer_Ionization api = GameObject.FindObjectOfType(typeof(Animation_Pointer_Ionization)) as Animation_Pointer_Ionization;
            api.setClicked(true);
			      si.release();
        }
        if(name == "Item 4"){
            ShowIonization si = GameObject.FindObjectOfType(typeof(ShowIonization)) as ShowIonization;
            Animation_Pointer_Magnetic apm = GameObject.FindObjectOfType(typeof(Animation_Pointer_Magnetic)) as Animation_Pointer_Magnetic;
            apm.setClicked(false);
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
