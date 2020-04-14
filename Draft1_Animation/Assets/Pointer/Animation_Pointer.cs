using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Pointer : MonoBehaviour
{
    private bool blink = false;
    void Start(){
      InvokeRepeating("Blink", 1.0f, 0.4f);
    }

    void Blink()
    {
      if()
      {
        blink = false;
      }
      else{
        blink = !blink;
      }
      this.gameObject.SetActive(blink);
    }
}
