using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagAttac : MonoBehaviour
{
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger("Sword_Attack_Basic");

        }
    }
}
