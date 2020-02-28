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

  void OnMouseDown(){
    oscillator1.SetActiveTrue();
    oscillator2.SetActiveTrue();
    oscillator3.SetActiveTrue();
    oscillator4.SetActiveTrue();
    oscillator5.SetActiveTrue();
    oscillator6.SetActiveTrue();
    oscillator7.SetActiveTrue();
    oscillator8.SetActiveTrue();
    oscillator1.beginAnimation = !oscillator1.beginAnimation;
    oscillator2.beginAnimation = !oscillator2.beginAnimation;
    oscillator3.beginAnimation = !oscillator3.beginAnimation;
    oscillator4.beginAnimation = !oscillator4.beginAnimation;
    oscillator5.beginAnimation = !oscillator5.beginAnimation;
    oscillator6.beginAnimation = !oscillator6.beginAnimation;
    oscillator7.beginAnimation = !oscillator7.beginAnimation;
    oscillator8.beginAnimation = !oscillator8.beginAnimation;

  }


}
