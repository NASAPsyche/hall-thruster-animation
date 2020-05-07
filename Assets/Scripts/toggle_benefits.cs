using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle_benefits : MonoBehaviour
{
    public GameObject benefits;

    public void showBenefits(){
        if(benefits.activeSelf){
            benefits.SetActive(false);
        }else{
            benefits.SetActive(true);
        }
        
    
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
