using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apperains : MonoBehaviour
{
    public Vector3 scale_country_x = new Vector3(1,0,0);
    public Vector3 scale_country_y = new Vector3(0, 1, 0);
    public Vector3 scale_country_x_y = new Vector3(0.5f, 0.5f, 0);
    public GameObject country;
    public ParametrsCountry parametrsCountry;
    public Attributes attributes;
    public ParametrLogic parametrLogic;
    
    private void Update()
    {
        if (attributes.administrius >= 250 && parametrsCountry.scholl >= 5 && parametrsCountry.coins_country >= 150)
        {
            parametrLogic.human += 1;
            country.transform.localScale = country.transform.localScale + scale_country_x;
            parametrsCountry.scholl -= 5;
            attributes.administrius -= 250;
            parametrsCountry.coins_country -= 150;
        }
        if (attributes.diplomaticus >= 250 && parametrsCountry.teatr >= 5 && parametrsCountry.coins_country >= 150)
        {
            parametrLogic.human += 1;
            country.transform.localScale = country.transform.localScale + scale_country_y;
            parametrsCountry.teatr -= 5;
            attributes.diplomaticus -= 250;
            parametrsCountry.coins_country -= 150;
        }
        if (attributes.voenus >= 250 && parametrsCountry.fabric >= 8 && parametrsCountry.coins_country >= 200)
        {
            parametrLogic.human += 1;
            country.transform.localScale = country.transform.localScale + scale_country_x_y;
            parametrsCountry.fabric -= 8;
            attributes.voenus -= 250;
            parametrsCountry.coins_country -= 200;
        }
    }
}
