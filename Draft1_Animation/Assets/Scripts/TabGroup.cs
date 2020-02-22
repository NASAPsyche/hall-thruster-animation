using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;
    public TabButton selectedTab;
    public Sprite tabSelected;
    public Sprite tabNotSelected;

    public List<GameObject> displayObjects;

    private void Start() 
    {
        foreach(TabButton button in tabButtons)
        {
            button.gameObject.SetActive(false);
        }
        tabButtons[0].gameObject.SetActive(true);

        foreach(GameObject gObject in displayObjects)
        {
            gObject.SetActive(false);
        }
        displayObjects[0].SetActive(true);
    }

    public void AddButton(TabButton button)
    {
        if(tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }

        tabButtons.Add(button);
    }

    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        if(selectedTab == null || button != selectedTab)
        {
            //button.GetComponent<Image>().color = new Color32(3, 145, 245, 255);
        }
        
    }
     public void OnTabExit(TabButton button)
    {
        ResetTabs();
        //button.GetComponent<Image>().color = new Color32(3, 82, 235, 255);
    }

     public void OnTabSelected(TabButton button)
    {
        selectedTab = button;        
        ResetTabs();
        button.GetComponent<Image>().sprite = tabSelected;        
        int index = button.transform.GetSiblingIndex();
        for(int i=0; i<displayObjects.Count; i++)
        {
            if(i == index)
            {
                displayObjects[i].SetActive(true);
            }else{
                displayObjects[i].SetActive(false);
            }
        }
    }

    public void ResetTabs()
    {
        foreach(TabButton button in tabButtons)
        {
            if(selectedTab!= null && button == selectedTab) {continue; }
            button.GetComponent<Image>().sprite = tabNotSelected;
        }
    }
}
