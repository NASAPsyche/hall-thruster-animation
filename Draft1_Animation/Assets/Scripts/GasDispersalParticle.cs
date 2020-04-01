using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasDispersalParticle : MonoBehaviour
{
    private bool releaseGas = false;
    private ParticleSystem ps;
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
        if(releaseGas){
          releaseGas = false;
            if(ps.isEmitting){
                ps.Pause(true);
                ps.Clear(true);
            }
            else{
                ps.Play(true);
            }
        }
    }

    public void release()
    {
      releaseGas = true;
    }
}
