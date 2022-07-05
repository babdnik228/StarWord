using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmiaLogic : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private ParametrsCountry parametrsCountry;
    [SerializeField] private Attributes attributes;
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
    public void ByeSoldier()
    {
        if(parametrsCountry.coins_country >= 100 && parametrsCountry.specialists >= 50 && attributes.administrius >= 100)
        {
            GameObject yes_a = Instantiate(yes_audio, transform.position, Quaternion.identity);
            Destroy(yes_a, 3f);
            parametrsCountry.soldier++;
            parametrsCountry.coins_country -= 100;
            parametrsCountry.specialists -= 50;
            attributes.administrius -= 100;
        }
        else
        {
            GameObject no_a = Instantiate(no_audio, transform.position, Quaternion.identity);
            Destroy(no_a, 3f);
        }
    }
    public void ByeWarMachine()
    {
        if (parametrsCountry.coins_country >= 100 && parametrsCountry.materials >= 50 && attributes.voenus >= 100)
        {
            GameObject yes_a = Instantiate(yes_audio, transform.position, Quaternion.identity);
            Destroy(yes_a, 3f);
            parametrsCountry.war_machine++;
            parametrsCountry.coins_country -= 100;
            parametrsCountry.materials -= 50;
            attributes.voenus -= 100;
        }
        else
        {
            GameObject no_a = Instantiate(no_audio, transform.position, Quaternion.identity);
            Destroy(no_a, 3f);
        }
    }
    public void ByePropaganda()
    {
        if (parametrsCountry.coins_country >= 100 && parametrsCountry.movies >= 50 && attributes.diplomaticus >= 100)
        {
            GameObject yes_a = Instantiate(yes_audio, transform.position, Quaternion.identity);
            Destroy(yes_a, 3f);
            parametrsCountry.propaganda++;
            parametrsCountry.coins_country -= 100;
            parametrsCountry.movies -= 50;
            attributes.diplomaticus -= 100;
        }
        else
        {
            GameObject no_a = Instantiate(no_audio, transform.position, Quaternion.identity);
            Destroy(no_a, 3f);
        }
    }
}
