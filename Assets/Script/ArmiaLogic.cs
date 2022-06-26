using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmiaLogic : MonoBehaviour
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
    public void ByeSoldier()
    {
        if(parametrsCountry.coins_country >= 100 && parametrsCountry.specialists >= 50 && attributes.administrius >= 100)
        {
            parametrsCountry.soldier++;
            parametrsCountry.coins_country -= 100;
            parametrsCountry.specialists -= 50;
            attributes.administrius -= 100;
        }
    }
    public void ByeWarMachine()
    {
        if (parametrsCountry.coins_country >= 100 && parametrsCountry.materials >= 50 && attributes.voenus >= 100)
        {
            parametrsCountry.war_machine++;
            parametrsCountry.coins_country -= 100;
            parametrsCountry.materials -= 50;
            attributes.voenus -= 100;
        }
    }
    public void ByePropaganda()
    {
        if (parametrsCountry.coins_country >= 100 && parametrsCountry.movies >= 50 && attributes.diplomaticus >= 100)
        {
            parametrsCountry.propaganda++;
            parametrsCountry.coins_country -= 100;
            parametrsCountry.movies -= 50;
            attributes.diplomaticus -= 100;
        }
    }
}
