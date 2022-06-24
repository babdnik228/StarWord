using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductLogic : MonoBehaviour
{
    public ParametrsCountry parametrsCountry;
    private void FixedUpdate()
    {
        if(parametrsCountry.scholl > 0)
        {
            parametrsCountry.specialists++;
        }
        else if(parametrsCountry.scholl == 0)
        {
            parametrsCountry.specialists = 0;
        }
    }
}
