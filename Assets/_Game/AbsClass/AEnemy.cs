using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AEnemy : MonoBehaviour
{
    public int _helth;

    public void TakeDamage(int damage)
    {
        _helth -= damage;
    }
}
