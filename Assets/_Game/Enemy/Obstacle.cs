using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private int damageObs;

    private void OnCollisionEnter(Collision collision)
    {
        PlayerManager playerManager = collision.gameObject.GetComponent<PlayerManager>();
        if(playerManager)
        {
            playerManager.TakeDamage(damageObs);
        }
    }
}
