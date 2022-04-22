using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject _panel;
    private void OnTriggerStay(Collider other)
    {
        Character character = other.GetComponent<Character>();
        if(character && Input.GetKeyDown(KeyCode.E))
        {
            _panel.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Character character = other.GetComponent<Character>();
        if (character)
        {
            _panel.SetActive(false);
        }
    }
}
