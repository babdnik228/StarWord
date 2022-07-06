using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCountruDipomat : MonoBehaviour
{
    private GameObject panelDiplomat;
    [SerializeField] private bool panel_active;
    private void Start()
    {
       // panelDiplomat = GameObject.FindGameObjectWithTag("PanelDiplomat");
    }
    void ClickPanelDiplomat()
    {
        if (panel_active == false)
        {
            panel_active = true;
        }
        else if (panel_active == true)
        {
            panel_active = false;
        }

        if (panel_active == true)
        {
            panelDiplomat.SetActive(true);
        }
        if (panel_active == false)
        {
            panelDiplomat.SetActive(false);
        }
    }
}
