using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBuilder : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private ParametrsCountry parametrsCountry;
    private bool panel_active = false;
    public void OpenPanel()
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
            panel.SetActive(true);
        }
        if (panel_active == false)
        {
            panel.SetActive(false);
        }
    }
    public void ByeScholl()
    {
        parametrsCountry.scholl++;
    }
    public void ByeFabric()
    {
        parametrsCountry.fabric++;
    }
    public void ByeTeatr()
    {
        parametrsCountry.teatr++;
    }
}
