using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Import : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private ParametrsCountry parametrsCountry;
    private bool panel_active = false;
    [SerializeField] private GameObject yes_audio;
    [SerializeField] private GameObject no_audio;
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
            GameObject yes_a = Instantiate(yes_audio, transform.position, Quaternion.identity);
            Destroy(yes_a, 3f);
            parametrsCountry.specialists+=25;
            parametrsCountry.coins_word -= 15;
            parametrsCountry.prestig -= 5;
            parametrsCountry.loyalty -= 5;
        }
        else
        {
            GameObject no_a = Instantiate(no_audio, transform.position, Quaternion.identity);
            Destroy(no_a, 3f);
        }
    }
    public void ByeMovie()
    {
        if (parametrsCountry.coins_word >= 15)
        {
            GameObject yes_a = Instantiate(yes_audio, transform.position, Quaternion.identity);
            Destroy(yes_a, 3f);
            parametrsCountry.movies+=25;
            parametrsCountry.coins_word -= 15;
            parametrsCountry.prestig -= 5;
            parametrsCountry.loyalty -= 5;
        }
        else
        {
            GameObject no_a = Instantiate(no_audio, transform.position, Quaternion.identity);
            Destroy(no_a, 3f);
        }
    }
    public void ByeMaterials()
    {
        if (parametrsCountry.coins_word >= 15)
        {
            GameObject yes_a = Instantiate(yes_audio, transform.position, Quaternion.identity);
            Destroy(yes_a, 3f);
            parametrsCountry.materials+=25;
            parametrsCountry.coins_word -= 15;
            parametrsCountry.prestig -= 5;
            parametrsCountry.loyalty -= 5;
        }
        else
        {
            GameObject no_a = Instantiate(no_audio, transform.position, Quaternion.identity);
            Destroy(no_a, 3f);
        }
    }
}
