using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticButton : MonoBehaviour
{
    public List<ShowMagneticField> magneticFieldScripts;

    public void clicked()
    {
      Debug.Log("click");
      foreach(ShowMagneticField magneticFieldScript in magneticFieldScripts)
      {
        magneticFieldScript.isShown = !magneticFieldScript.isShown;
      }
    }
}
