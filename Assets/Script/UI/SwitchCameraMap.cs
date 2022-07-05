using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameraMap : MonoBehaviour
{
    [SerializeField] private GameObject CameraMainBasic;
    [SerializeField] private GameObject[] objectPanel;
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
            for (int i = 0; i < objectPanel.Length; i++)
            {
                objectPanel[i].SetActive(true);
            }
        }
        if (switchCam == true)
        {
            CameraMainBasic.GetComponent<Camera>().orthographicSize = 35;
            for (int i = 0; i < objectPanel.Length; i++)
            {
                objectPanel[i].SetActive(false);
            }
        }
    }
}
