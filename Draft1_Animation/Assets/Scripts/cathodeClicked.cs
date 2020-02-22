using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cathodeClicked : MonoBehaviour
{
    public Animator animatortest;

    public void Start(){
      animatortest = GetComponent<Animator>();
    }

  void OnMouseDown(){
      Debug.Log("Hey");
      animatortest.Play("New Animation");
  }


}
