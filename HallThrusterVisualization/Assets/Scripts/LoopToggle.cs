using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoopToggle : MonoBehaviour
{
  public Toggle ToggleButton;
  public Sprite toggleActive;
  public Sprite toggleInactive;

  public GameObject[] AccordionObjects;

  public GameObject BlinkingArrowMagnetic;
  public GameObject BlinkingArrowElectron;
  public GameObject BlinkingArrowXenon;
  public GameObject BlinkingArrowIonization;

  bool buttonState;
  Sprite currentImage;

  public void SetToggleImage()
  {

      ToggleButton = GetComponent<Toggle>();

      buttonState = ToggleButton.isOn;


      foreach(GameObject acc in AccordionObjects)
      {
          acc.GetComponent<UIAccordionElement>().OnValueChanged(false);
      }
      // AccordionObjects[4].GetComponent<UIAccordionElement>().OnValueChanged(true);

      if(buttonState)
      {
          ToggleButton.GetComponent<Image>().sprite = toggleActive;
          StartCoroutine(WaitNextAnimation());
      }
      else
      {
          ToggleButton.GetComponent<Image>().sprite = toggleInactive;
      }
  }

  private IEnumerator WaitNextAnimation()
  {
    while(buttonState)
    {
      int i = 0;
      foreach(GameObject acc in AccordionObjects)
      {
        if(!buttonState)
        {
          break;
        }
        acc.GetComponent<UIAccordionElement>().OnValueChanged(true);
        BlinkingArrowMagnetic.GetComponent<Animation_Pointer_Magnetic>().setClicked(true);
        BlinkingArrowElectron.GetComponent<Animation_Pointer_Electron>().setClicked(true);
        BlinkingArrowXenon.GetComponent<Animation_Pointer_Gas>().setClicked(true);
        BlinkingArrowIonization.GetComponent<Animation_Pointer_Ionization>().setClicked(true);
        if(i==4)
        {
          yield return new WaitForSeconds(2f);
        }
        else
        {
          yield return new WaitForSeconds(7f);
        }
        i++;
        acc.GetComponent<UIAccordionElement>().OnValueChanged(false);
      }
    }
  }


}
