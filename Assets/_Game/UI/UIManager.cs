using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private PlayerManager _playerManager;
    [Space]
    [SerializeField]
    private Text _coinsUIText;
    [Space]
    [SerializeField]
    private Slider _helthSliderUI;
    [SerializeField]
    private Slider _helthSliderMaxUI;
    [Space]
    [SerializeField]
    private Slider _energySliderUI;
    [SerializeField]
    private Slider _energySliderMaxUI;
    [Space]
    [SerializeField]
    private Text _physicArmorUI;
    [SerializeField]
    private Text _magicArmorUI;

    
    private void Update()
    {
        _coinsUIText.text = _playerManager._coins.ToString();        
        _helthSliderMaxUI.maxValue = _playerManager._helthMax;
        _helthSliderUI.value = _playerManager._helth;
        _energySliderMaxUI.maxValue = _playerManager._energyMax;
        _energySliderUI.value = _playerManager._energy;
        _physicArmorUI.text = _playerManager._phusicArmor.ToString();
        _magicArmorUI.text = _playerManager._magicArmor.ToString();
    }
}
