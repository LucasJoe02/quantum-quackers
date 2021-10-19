using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public sfx sfx_manager;

    public CharacterController2D Controller;
    public Animator animator;

    public float moveSpeed = 40f;

    private float horizontalMove = 0f;
    private bool jump = false;

    // Update is called once per frame
    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("IsJumping", true);
            jump = true;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);

        sfx_manager.sfx_Landing();
    }

    private void FixedUpdate()
    {
        // Movement

        Controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}