using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowIonization : MonoBehaviour
{
   private ParticleSystem ps;
   private bool ionize = false;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ps.Pause(true);
        ps.Clear(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if xenon gas should be made visible (on X click)
        if(ionize){
          ionize = false;
            if(ps.isEmitting){
                ps.Pause(true);
                ps.Clear(true);
            }
            else{
                ps.Play(true);
            }

        }
    }

    public void release(){
      ionize = true;
    }
}
