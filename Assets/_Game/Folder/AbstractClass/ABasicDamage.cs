using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ABasicDamage : MonoBehaviour
{
   public virtual void ReciewDamage()
    {
        Die();
    }   
    private void Die()
    {
        Destroy(gameObject);
    }
}
