using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    bool InfoEnabled = false;
    public Texture BoxTexture;

    GUIContent LabelContent, InfoContent;
    GUIStyle style = new GUIStyle();

    void Start()
    {
        LabelContent = new GUIContent("Press 'i' for information");
        InfoContent = new GUIContent("Information to be displayed");

        style.normal.textColor = Color.yellow;
    }

    void Update () {
        if(Input.GetKeyDown(KeyCode.I)) {
            InfoEnabled = !InfoEnabled;
        }
    }


    void OnGUI()
        {
            GUI.Label(new Rect(0, 0, Screen.width, Screen.height), LabelContent, style);

            if(InfoEnabled) {
                GUI.Box(new Rect(0, 50, Screen.width, Screen.height), InfoContent, style);
            }else{
                InfoEnabled = false;
            }
        }

}
