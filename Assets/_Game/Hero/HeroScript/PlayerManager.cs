using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : BasicDamage
{
    public int _coins;
    [Space]
    public int _phusicArmor;
    public int _magicArmor;
    [Space]
    public float _speedBonus;
    [Space]
    public int _helth;
    public int _helthMax;
    [Space]
    public int _energy;
    public int _energyMax;

    private void Update()
    {
        _coins++;

    }
    public void TakeDamage(int damage)
    {
        _helth -= damage;
        if(_helth <= 0)
        {
            ReciewDamage();
        }
    }
}
