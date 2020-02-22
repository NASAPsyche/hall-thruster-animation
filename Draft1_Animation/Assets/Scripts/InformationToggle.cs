using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationToggle : MonoBehaviour
{
    public GameObject InformationPanel;

    public void OpenPanel()
    {
        if(InformationPanel != null)
        {
            bool isActive = InformationPanel.activeSelf;
            InformationPanel.SetActive(!isActive);
        }
    }
}
