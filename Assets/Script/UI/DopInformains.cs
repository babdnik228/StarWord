using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DopInformains : MonoBehaviour
{
    [SerializeField] private GameObject informainions;
    private void OnMouseEnter()
    {
        informainions.SetActive(true);
    }
    private void OnMouseExit()
    {
        informainions.SetActive(false);
    }
}
