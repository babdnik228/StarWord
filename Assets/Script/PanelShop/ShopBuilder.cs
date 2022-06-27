using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBuilder : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private ParametrsCountry parametrsCountry;
    [SerializeField] private Attributes attributes;
    [SerializeField] private GameObject yes_audio;
    [SerializeField] private GameObject no_audio;
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

        if (panel_active == true )
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
            GameObject yes_a = Instantiate(yes_audio, transform.position, Quaternion.identity);
            Destroy(yes_a, 3f);
            parametrsCountry.scholl++;
            parametrsCountry.coins_country -= 100;
            parametrsCountry.humans -= 100;
            attributes.administrius -= 100;
            parametrsCountry.prestig += 5;
            parametrsCountry.loyalty += 5;
        }
        else
        {
            GameObject no_a = Instantiate(no_audio, transform.position, Quaternion.identity);
            Destroy(no_a, 3f);
        }
    }
    public void ByeFabric()
    {
        if (parametrsCountry.coins_country >= 100 && parametrsCountry.humans >= 100 && attributes.voenus >= 100)
        {
            GameObject yes_a = Instantiate(yes_audio, transform.position, Quaternion.identity);
            Destroy(yes_a, 3f);
            parametrsCountry.fabric++;
            parametrsCountry.coins_country -= 100;
            parametrsCountry.humans -= 100;
            attributes.voenus -= 100;
            parametrsCountry.prestig += 5;
            parametrsCountry.loyalty += 5;
        }
        else
        {
            GameObject no_a = Instantiate(no_audio, transform.position, Quaternion.identity);
            Destroy(no_a, 3f);
        }
    }
    public void ByeTeatr()
    {
        if (parametrsCountry.coins_country >= 100 && parametrsCountry.humans >= 100 && attributes.diplomaticus >= 100)
        {
            GameObject yes_a = Instantiate(yes_audio, transform.position, Quaternion.identity);
            Destroy(yes_a, 3f);
            parametrsCountry.teatr++;
            parametrsCountry.coins_country -= 100;
            parametrsCountry.humans -= 100;
            attributes.diplomaticus -= 100;
            parametrsCountry.prestig += 5;
            parametrsCountry.loyalty += 5;
        }
        else
        {
            GameObject no_a = Instantiate(no_audio, transform.position, Quaternion.identity);
            Destroy(no_a, 3f);
        }
    }
}
