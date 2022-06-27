using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stabilnost : MonoBehaviour
{
    public ParametrsCountry parametrsCountry;
    public Attributes attributes;
    public Leader leader;
    [SerializeField] private GameObject yes_audio;
    [SerializeField] private GameObject no_audio;
    public void ClickButtonStab()
    {
        if(attributes.administrius >= 200 && attributes.diplomaticus >= 200 && attributes.voenus >= 200 && parametrsCountry.prestig >= 20 && parametrsCountry.loyalty >= 20 && parametrsCountry.humans >= 100)
        {
            GameObject yes_a = Instantiate(yes_audio, transform.position, Quaternion.identity);
            Destroy(yes_a, 3f);
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
        else
        {
            GameObject no_a = Instantiate(no_audio, transform.position, Quaternion.identity);
            Destroy(no_a, 3f);
        }
    }
}
