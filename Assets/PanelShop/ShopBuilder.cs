using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBuilder : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private ParametrsCountry parametrsCountry;
    [SerializeField] private Attributes attributes;
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
        if(parametrsCountry.coins_country >= 100 && parametrsCountry.humans >= 100 && attributes.administrius >= 100 )
        {
            parametrsCountry.scholl++;
            parametrsCountry.coins_country -= 100;
            parametrsCountry.humans -= 100;
            attributes.administrius -= 100;
            parametrsCountry.prestig += 5;
            parametrsCountry.loyalty += 5;
        }
    }
    public void ByeFabric()
    {
        if (parametrsCountry.coins_country >= 100 && parametrsCountry.humans >= 100 && attributes.voenus >= 100)
        {
            parametrsCountry.fabric++;
            parametrsCountry.coins_country -= 100;
            parametrsCountry.humans -= 100;
            attributes.voenus -= 100;
            parametrsCountry.prestig += 5;
            parametrsCountry.loyalty += 5;
        }
    }
    public void ByeTeatr()
    {
        if (parametrsCountry.coins_country >= 100 && parametrsCountry.humans >= 100 && attributes.diplomaticus >= 100)
        {
            parametrsCountry.teatr++;
            parametrsCountry.coins_country -= 100;
            parametrsCountry.humans -= 100;
            attributes.diplomaticus -= 100;
            parametrsCountry.prestig += 5;
            parametrsCountry.loyalty += 5;
        }
    }
}
