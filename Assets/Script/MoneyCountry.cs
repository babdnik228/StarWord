using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCountry : MonoBehaviour
{
    [SerializeField] private ParametrsCountry _parCountry;
    private void FixedUpdate()
    {
        _parCountry.coins_country+=1;
    }
}
