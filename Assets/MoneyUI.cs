using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoneyUI : MonoBehaviour
{
    [SerializeField] private Text text_coins_country;
    [SerializeField] private Text text_coins_word;
    [SerializeField] private ParametrsCountry parametrsCountry;
    private void Update()
    {
        text_coins_country.text = parametrsCountry.coins_country.ToString();
        text_coins_word.text = parametrsCountry.coins_word.ToString();
    }
}
