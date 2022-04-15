using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICoins : MonoBehaviour
{
    [SerializeField]
    private Text _coinsUIText;
    [SerializeField]
    private PlayerManager playerManager;
    private void Update()
    {
        _coinsUIText.text = playerManager._coins.ToString();
    }
}
