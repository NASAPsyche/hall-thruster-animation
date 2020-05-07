using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMagneticField : MonoBehaviour
{
    public bool isShown = false;
    // Start is called before the first frame update
    void Start()
    {
         MagneticButton mb = GameObject.FindObjectOfType(typeof(MagneticButton)) as MagneticButton;
			   mb.resetAnim();
         transform.gameObject.GetComponent<Renderer>().enabled = isShown;
    }

    // Update is called once per frame
    void Update()
    {
      transform.gameObject.GetComponent<Renderer>().enabled = isShown;
    }
}
