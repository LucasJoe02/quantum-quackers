using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D Controller;

    public float moveSpeed = 40f;

    private float horizontalMove = 0f;
    private bool jump = false;

    // Update is called once per frame
    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        Controller.Switch();
        // Movement
        Controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}