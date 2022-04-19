using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobOne : AEnemy
{
    [SerializeField]
    private int damage;
    private void OnTriggerExit(Collider other)
    {
        DamagAttac damagAttac = other.GetComponent<DamagAttac>();
        if(damagAttac != null)
        {
            TakeDamage(damage);
            if(_helth <= 0)
            {
                Destroy(gameObject);
            }
        }    
    }
}
