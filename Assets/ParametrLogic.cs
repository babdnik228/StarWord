using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametrLogic : MonoBehaviour
{
    public ParametrsCountry parametrsCountry;

    private void FixedUpdate()
    {
        if (parametrsCountry.prestig <= parametrsCountry.prestig_max)
        {
            StartCoroutine(Cor_Prestig());
        }
        if (parametrsCountry.loyalty <= parametrsCountry.loyalty_max)
        {
            StartCoroutine(Cor_Loyalty());
        }
        if (parametrsCountry.humans <= parametrsCountry.humans_Max)
        {
            StartCoroutine(Cor_Human());
        }

    }
    IEnumerator Cor_Prestig()
    {
        yield return new WaitForSeconds(0.1f);    
        parametrsCountry.prestig++;
    }
    IEnumerator Cor_Loyalty()
    {
        yield return new WaitForSeconds(0.1f);
        parametrsCountry.loyalty++;
    }
    IEnumerator Cor_Human()
    {
        yield return new WaitForSeconds(0.1f);
        parametrsCountry.humans++;
    }
   
}
