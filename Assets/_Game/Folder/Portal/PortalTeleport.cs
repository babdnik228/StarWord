using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PortalTeleport : MonoBehaviour
{
    [SerializeField]
    private Transform _targetSpawn;
    private void OnTriggerEnter(Collider other)
    {
        Character character = other.GetComponent<Character>();
        if(character)
        {
            character.GetComponent<NavMeshAgent>().Warp(_targetSpawn.transform.position);
        }
    }
}
