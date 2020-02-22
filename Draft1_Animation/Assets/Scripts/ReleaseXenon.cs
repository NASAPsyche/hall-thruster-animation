using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseXenon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.gameObject.GetComponent<Renderer>().enabled=false;
    }

    // Update is called once per frame
    public void Update()
    {
        //Checks if xenon gas should be made visible (on X click)
        if(Input.GetKeyDown(KeyCode.X)){
            transform.gameObject.GetComponent<Renderer>().enabled=true;

        }
        if(transform.gameObject.GetComponent<Renderer>().enabled==true){
          //transform.position = riseXenon();
          
        }
    }

    // public Vector3 riseXenon()
    // {
    //   float curYVal = transform.position.y;
    //   if(curYVal<=.2){
    //       curYVal+=Time.deltaTime/1.5f;
    //       return new Vector3(transform.position.x, curYVal, transform.position.z);
    //   }
    //   return new Vector3(transform.position.x, curYVal, transform.position.z);
    // }
}
