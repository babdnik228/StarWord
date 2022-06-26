using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametrLogic : MonoBehaviour
{
    public ParametrsCountry parametrsCountry;

    private void FixedUpdate()
    {
        if (parametrsCountry.humans <= parametrsCountry.humans_Max)
        {
            StartCoroutine(Cor_Human());
        }
    }

    IEnumerator Cor_Human()
    {
        yield return new WaitForSeconds(0.1f);
        parametrsCountry.humans++;
    }
   
}
