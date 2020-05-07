using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasDispersalInfo : MonoBehaviour
{
    string text = "This is the Gas Dispersal";
 
    private string currentToolTipText = "";
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseEnter ()
    {
        currentToolTipText = text;
    }

    void OnMouseExit ()
    {
        currentToolTipText = "";
    }

    void OnGUI()
    {
        if (currentToolTipText != "")
        {
            var x = Event.current.mousePosition.x;
            var y = Event.current.mousePosition.y;
            GUI.Label (new Rect (x-149,y+40,300,60), currentToolTipText);

        }
    }
}
