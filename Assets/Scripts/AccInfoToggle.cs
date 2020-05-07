using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccInfoToggle : MonoBehaviour
{
    public Toggle ToggleButton;
    public Sprite toggleActive;
    public Sprite toggleInactive;

    public GameObject[] TechInfo;

    public GameObject[] NonTechInfo;
    bool buttonState;
    Sprite currentImage;

    public void SetToggleImage(){

        ToggleButton = GetComponent<Toggle>();

        buttonState = ToggleButton.isOn;

        

        if(buttonState == true){
            ToggleButton.GetComponent<Image>().sprite = toggleActive;
            foreach(GameObject info in TechInfo){
                info.SetActive(true);
                UIAccordionElement uie = GameObject.Find("Item 2").GetComponent<UIAccordionElement>();
            }
            foreach(GameObject info in NonTechInfo){
                info.SetActive(false);
            }
        }else{
            ToggleButton.GetComponent<Image>().sprite = toggleInactive;
             foreach(GameObject info in TechInfo){
                info.SetActive(false);
            }
            foreach(GameObject info in NonTechInfo){
                info.SetActive(true);
                UIAccordionElement uie = GameObject.Find("Item 2").GetComponent<UIAccordionElement>();
            }
        }

    }
}
