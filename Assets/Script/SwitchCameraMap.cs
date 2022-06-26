using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameraMap : MonoBehaviour
{
    [SerializeField] private GameObject CameraMainBasic;
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
            CameraMainBasic.GetComponent<Camera>().orthographicSize = 5;
        }
        if (switchCam == true)
        {
            CameraMainBasic.GetComponent<Camera>().orthographicSize = 35;
        }
    }
}
