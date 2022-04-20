using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabloActiv : MonoBehaviour
{
    [SerializeField]
    private GameObject _tabloObject;
    private void OnTriggerEnter(Collider other)
    {
        PlayerManager playerManager = other.GetComponent<PlayerManager>();
        if(playerManager != null)
        {
            _tabloObject.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        PlayerManager playerManager = other.GetComponent<PlayerManager>();

        if (playerManager && Input.GetKeyDown(KeyCode.F))
        {
            _tabloObject.SetActive(false);
            Debug.Log("Пошёл нахуй");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerManager playerManager = other.GetComponent<PlayerManager>();
        if (playerManager != null)
        {
            _tabloObject.SetActive(false);
        }
    }
  
}
