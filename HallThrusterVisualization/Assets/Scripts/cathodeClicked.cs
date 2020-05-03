using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cathodeClicked : MonoBehaviour
{
  public Oscillator oscillator1;
  public Oscillator oscillator2;
  public Oscillator oscillator3;
  public Oscillator oscillator4;
  public Oscillator oscillator5;
  public Oscillator oscillator6;
  public Oscillator oscillator7;
  public Oscillator oscillator8;

  public void OnMouseDown()
  {
    oscillator1.SetActiveTrue();
    oscillator2.SetActiveTrue();
    oscillator3.SetActiveTrue();
    oscillator4.SetActiveTrue();
    oscillator5.SetActiveTrue();
    oscillator6.SetActiveTrue();
    oscillator7.SetActiveTrue();
    oscillator8.SetActiveTrue();
  }

  public void resetAnim(){
    oscillator1.resetAnim();
    oscillator2.resetAnim();
    oscillator3.resetAnim();
    oscillator4.resetAnim();
    oscillator5.resetAnim();
    oscillator6.resetAnim();
    oscillator7.resetAnim();
    oscillator8.resetAnim();
  }


}
