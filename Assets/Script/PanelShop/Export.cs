using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Export : MonoBehaviour
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
    public void SellSpecialists()
    {
        if (parametrsCountry.specialists >= 1)
        {
            parametrsCountry.specialists-= 25;
            parametrsCountry.humans -= 20;
            parametrsCountry.coins_word += 15;
        }
    }
    public void SellMovie()
    {
     if(parametrsCountry.movies >= 1)
        {
            parametrsCountry.movies-= 25;
            parametrsCountry.humans -= 20;
            parametrsCountry.coins_word += 15;
        }
    }
    public void SellMaterials()
    {
       if(parametrsCountry.materials >= 1)
        {
            parametrsCountry.materials-= 25;
            parametrsCountry.humans -= 20;
            parametrsCountry.coins_word += 15;
        }
    }
}
