using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stabilnost : MonoBehaviour
{
    public ParametrsCountry parametrsCountry;
    public Attributes attributes;
    public Leader leader;
   public void ClickButtonStab()
    {
        if(attributes.administrius >= 200 && attributes.diplomaticus >= 200 && attributes.voenus >= 200 && parametrsCountry.prestig >= 20 && parametrsCountry.loyalty >= 20 && parametrsCountry.humans >= 100)
        {
            leader.characteristic_diplomatic += 1;
            leader.characteristic_administraunion += 1;
            leader.characteristic_voen += 1;
            //
            attributes.administrius -= 200;
            attributes.diplomaticus -= 200;
            attributes.voenus -= 200;
            parametrsCountry.prestig -= 20;
            parametrsCountry.loyalty -= 20;
            parametrsCountry.humans -= 100;
        }
    }
}
