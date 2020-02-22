using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleTechnical : MonoBehaviour
{
    public Toggle ToggleButton;
    public Sprite toggleActive;
    public Sprite toggleInactive;
    bool buttonState;

    public TabButton destab;
    public TabGroup tabGrouper;

    Sprite currentImage;

    public void SetToggleImage(){

        ToggleButton = GetComponent<Toggle>();

        buttonState = ToggleButton.isOn;

        if(buttonState == true){
            ToggleButton.GetComponent<Image>().sprite = toggleActive;
            tabGrouper.OnTabSelected(destab, ToggleButton);
        }else{
            ToggleButton.GetComponent<Image>().sprite = toggleInactive;
            tabGrouper.OnTabSelected(destab, ToggleButton);
        }        
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
