using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Import : MonoBehaviour
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
    public void ByeSpecialists()
    {
        if(parametrsCountry.coins_word >= 15)
        {
            parametrsCountry.specialists+=5;
            parametrsCountry.coins_word -= 15;
            parametrsCountry.prestig -= 5;
            parametrsCountry.loyalty -= 10;
        }
        
    }
    public void ByeMovie()
    {
        if (parametrsCountry.coins_word >= 15)
        {
            parametrsCountry.movies+=5;
            parametrsCountry.coins_word -= 15;
            parametrsCountry.prestig -= 5;
            parametrsCountry.loyalty -= 10;
        }
    }
    public void ByeMaterials()
    {
        if (parametrsCountry.coins_word >= 15)
        {
            parametrsCountry.materials+=5;
            parametrsCountry.coins_word -= 15;
            parametrsCountry.prestig -= 5;
            parametrsCountry.loyalty -= 10;
        }
    }
}
