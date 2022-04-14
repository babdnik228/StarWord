using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopActiv : MonoBehaviour
{
    [SerializeField]
    private GameObject _panelShop;
    private void OnTriggerStay(Collider other)
    {
        Character character = other.GetComponent<Character>();
        if(character && Input.GetKeyDown(KeyCode.E))
        {
            _panelShop.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Character character = other.GetComponent<Character>();
        if (character)
        {
            _panelShop.SetActive(false);
        }
    }
}
