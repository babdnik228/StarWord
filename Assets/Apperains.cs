using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apperains : MonoBehaviour
{
    public Vector2 scale_country;
    private void Start()
    {
        transform.localScale = scale_country;
    }
}
