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
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Sword Attack");
            _animator.SetTrigger("Sword_Attack_Basic");
        }
    }
}
