using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMaster : MonoBehaviour
{
    [SerializeField] private float speedNormal;
    [SerializeField] private float jumpForce;

    private float gravity;
    private Vector3 moveVec;

    private CharacterController character;
    private Animator anim;

    private void Awake()
    {
        character = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        CharacterMoveLogic();
        CharacterGravityLogic();
    }
    private void FixedUpdate()
    {
        
    }
    private void CharacterMoveLogic()
    {
        moveVec = Vector3.zero;
        moveVec.x = Input.GetAxisRaw("Horizontal") * speedNormal;
        moveVec.z = Input.GetAxisRaw("Vertical") * speedNormal;
        moveVec.y = gravity;

        character.Move(moveVec * Time.deltaTime);
    }
    private void CharacterGravityLogic()
    {
        if (!character.isGrounded) gravity -= 20 * Time.deltaTime;
        else gravity = -1f;
    }



}
