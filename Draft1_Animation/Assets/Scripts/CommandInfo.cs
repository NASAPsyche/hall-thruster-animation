using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInfo : MonoBehaviour
{
    public GameObject ElectronInfo;
    public GameObject XenonInfo;
    public GameObject CameraInfo;

    public void ShowElectronCommands()
    {
        if(ElectronInfo != null)
        {
            bool isActive = ElectronInfo.activeSelf;
            ElectronInfo.SetActive(!isActive);
        }
    }

    public void ShowXenonCommands()
    {
        if(XenonInfo != null)
        {
            bool isActive = XenonInfo.activeSelf;
            XenonInfo.SetActive(!isActive);
        }
    }

    public void ShowCameraCommands()
    {
        if(CameraInfo != null)
        {
            bool isActive = CameraInfo.activeSelf;
            CameraInfo.SetActive(!isActive);
        }
    }

    public void SetInfoInactive()
    {
        XenonInfo.SetActive(false);
        ElectronInfo.SetActive(false);
        CameraInfo.SetActive(false);
    }
}
