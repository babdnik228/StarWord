using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scip : MonoBehaviour
{
    [SerializeField]
    private GameObject _scipButton;
    [SerializeField]
    private GameObject _character;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _scipButton.SetActive(false);
            _character.SetActive(true);
            Destroy(gameObject);
        }
    }
    public void CLickScip()
    {
        _scipButton.SetActive(false);
        _character.SetActive(true);
        Destroy(gameObject);
    }
}
