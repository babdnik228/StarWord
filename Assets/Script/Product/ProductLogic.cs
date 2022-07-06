using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductLogic : MonoBehaviour
{
    public ParametrsCountry parametrsCountry;
    public MoneyCountry moneyCountry;
    private void FixedUpdate()
    {
        if(parametrsCountry.scholl > 0)
        {
          
            parametrsCountry.specialists++;
        }
        else if(parametrsCountry.scholl == 0)
        {
            parametrsCountry.specialists--;
        }
        if (parametrsCountry.specialists <= 0)
        {
            parametrsCountry.specialists = 0;
        }
        if (parametrsCountry.fabric > 0)
        {
            
            parametrsCountry.materials++;
        }
        else if (parametrsCountry.fabric == 0)
        {
            parametrsCountry.materials--;
        }
         if (parametrsCountry.materials <= 0)
        {
            parametrsCountry.materials = 0;
        }
        if (parametrsCountry.teatr > 0)
        {
            
            parametrsCountry.movies++;
        }
        else if (parametrsCountry.teatr == 0)
        {
            parametrsCountry.movies--;
        }
        if (parametrsCountry.movies <= 0)
        {
            parametrsCountry.movies = 0;
        }
    }
}
