using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Pointer_Magnetic : MonoBehaviour
{
    private bool clicked = false;
    private bool blink = false;
    void Start()
    {
      InvokeRepeating("Blink", 1.0f, 0.4f);
    }

    public void setClicked(bool clicked)
    {
      this.clicked = clicked;
    }

    void Blink()
    {
      if(clicked)
      {
        blink = false;
      }
      else
      {
        blink = !blink;
      }
      Vector3 shape;
      if(blink)
      {
       shape = new Vector3(1, 1, 1);
      }
      else{
       shape = new Vector3(0, 0, 0);
     }
      this.gameObject.transform.localScale = shape;
    }
}
