using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipMoney : MonoBehaviour
{
    [SerializeField] private MoneyCountry moneyCountry;
    [SerializeField] private ParametrsCountry parametrsCountry;
    //Money
    public void BuyCountryMoney()
    {
        if(parametrsCountry.coins_country >= 25)
        {
            
        parametrsCountry.coins_country -= 25;
        parametrsCountry.coins_word += 5;
        }
    }
    public void BuyWordCountryMoney()
    {
        if(parametrsCountry.coins_word >= 6)
        {
        parametrsCountry.coins_country += 20;
        parametrsCountry.coins_word -= 6;
        }
    }
    //Builder
    public void ByeScholl()
    {
        if(parametrsCountry.scholl >= 1)
        {
            parametrsCountry.scholl -= 1;
            parametrsCountry.coins_country += 75;
        }
    }
    public void ByeFabric()
    {
        if (parametrsCountry.fabric >= 1)
        {
            parametrsCountry.fabric -= 1;
            parametrsCountry.coins_country += 75;
        }
    }
    public void ByeTheatr()
    {
        if (parametrsCountry.teatr >= 1)
        {
            parametrsCountry.teatr -= 1;
            parametrsCountry.coins_country += 75;
        }
    }
    //Specialist
    public void ByeSpecialist()
    {
        if (parametrsCountry.specialists >= 100)
        {
            parametrsCountry.specialists -= 100;
            parametrsCountry.coins_country += 50;
        }
    }
    public void ByeMaterials()
    {
        if (parametrsCountry.specialists >= 100)
        {
            parametrsCountry.specialists -= 100;
            parametrsCountry.coins_country += 50;
        }
    }
    public void ByeMovie()
    {
        if (parametrsCountry.movies >= 100)
        {
            parametrsCountry.movies -= 100;
            parametrsCountry.coins_country += 50;
        }
    }
    //Armia
    public void ByeSoldier()
    {
        if (parametrsCountry.soldier >= 1)
        {
            moneyCountry.coins_c++;
            parametrsCountry.soldier -= 1;
            parametrsCountry.coins_country += 70;
        }
    }
    public void ByeWarMachine()
    {
        if (parametrsCountry.war_machine >= 1)
        {
            moneyCountry.coins_c++;
            parametrsCountry.war_machine -= 1;
            parametrsCountry.coins_country += 70;
        }
    }
    public void ByePropaganda()
    {
        if (parametrsCountry.propaganda >= 1)
        {
            moneyCountry.coins_c++;
            parametrsCountry.propaganda -= 1;
            parametrsCountry.coins_country += 70;
        }
    }
    //Loilnost and Prestig
    public void ByeLoailnost()
    {
        if (parametrsCountry.loyalty >= 2)
        {
            parametrsCountry.loyalty -= 2;
            parametrsCountry.coins_country += 175;
        }
    }
    public void ByePrestig()
    {
        if (parametrsCountry.prestig >= 2)
        {
            parametrsCountry.prestig -= 2;
            parametrsCountry.coins_country += 175;
        }
    }
}
