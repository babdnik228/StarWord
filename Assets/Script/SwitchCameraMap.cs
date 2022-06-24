using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameraMap : MonoBehaviour
{
    [SerializeField] private GameObject CameraMainBasic;
    [SerializeField] private GameObject CameraTwoAggit;
    private bool switchCam = false;

    public void SwitchCamera()
    {
        if (switchCam == false)
        {
            switchCam = true;
        }
        else if (switchCam == true)
        {
            switchCam = false;
        }

        if (switchCam == false)
        {
            CameraMainBasic.active = true;
            CameraTwoAggit.active = false;
        }
        if (switchCam == true)
        {
            CameraMainBasic.active = false;
            CameraTwoAggit.active = true;
        }
    }
}
