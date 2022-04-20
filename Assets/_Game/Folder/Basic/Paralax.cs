using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    [SerializeField]
    private float _startX;
    [SerializeField]
    private float _endX;
    [SerializeField]
    private float _speedParalax;
    private void Update()
    {
        transform.Translate(Vector2.left * _speedParalax * Time.deltaTime);
        if(transform.position.x <= _endX)
        {
            Vector2 pos = new Vector2(_startX, transform.position.y);
            transform.position = pos;
        }
    }
}
