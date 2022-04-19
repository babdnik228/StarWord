using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDamage : MonoBehaviour
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
