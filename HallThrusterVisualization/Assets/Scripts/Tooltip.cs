using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    public GameObject backgroundImage;
    public GameObject textField;
    public GameObject componentCanvas;

    void Start()
    {
      
    }

    void OnMouseEnter ()
    {
        componentCanvas.SetActive(true);
        textField.SetActive(true);
        var textTransform = textField.GetComponent<RectTransform>();
        float width = textTransform.sizeDelta.x;
        float height = textTransform.sizeDelta.y;
        backgroundImage.SetActive(true);
        backgroundImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
        backgroundImage.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
    }

    void OnMouseExit ()
    {
        componentCanvas.SetActive(false);
        backgroundImage.SetActive(false);
        textField.SetActive(false);
    }

    void OnGUI()
    {
        var x = Input.mousePosition.x;
        var y = Input.mousePosition.y;
        float xoff = (.5f*backgroundImage.GetComponent<RectTransform>().sizeDelta.x) + 10;
        float yoff = (.5f*backgroundImage.GetComponent<RectTransform>().sizeDelta.y);
        backgroundImage.transform.position = new Vector2(x + xoff, y - yoff);
    }
}
