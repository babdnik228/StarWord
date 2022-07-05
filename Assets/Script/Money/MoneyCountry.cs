using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCountry : MonoBehaviour
{
    [SerializeField] private ParametrsCountry _parCountry;
    public int coins_c;

   
    private void FixedUpdate()
    {
        _parCountry.coins_country+=coins_c;
    }
}
