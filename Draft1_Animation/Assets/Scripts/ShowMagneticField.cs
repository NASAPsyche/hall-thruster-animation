using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMagneticField : MonoBehaviour
{
    bool isShown = false;
    // Start is called before the first frame update
    void Start()
    {
         transform.gameObject.GetComponent<Renderer>().enabled = isShown;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M)){
            isShown = !isShown;
            transform.gameObject.GetComponent<Renderer>().enabled = isShown;
        }
    }
}
