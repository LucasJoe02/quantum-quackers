using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Range(0, 3)]
    public int ChargeLevel;

    public CharacterController2D Controller;

    public float moveSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        // Movement
        Controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}
