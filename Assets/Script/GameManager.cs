using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject StartBlac;
    private void Awake()
    {
        Destroy(StartBlac, 1.5f);
    }
}
