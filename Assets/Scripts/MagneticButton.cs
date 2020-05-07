using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticButton : MonoBehaviour
{
    public List<ShowMagneticField> magneticFieldScripts;

    public void clicked()
    {
      foreach(ShowMagneticField magneticFieldScript in magneticFieldScripts)
      {
        magneticFieldScript.isShown = true;
      }
    }

    public void resetAnim(){
        foreach(ShowMagneticField magneticFieldScript in magneticFieldScripts)
        {
          magneticFieldScript.isShown = false;
        }
    }
}
