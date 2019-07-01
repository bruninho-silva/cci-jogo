using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    public Joystick joystick;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    /*public Rigidbody2D police;*/



    // Update is called once per frame
    void Update()
    {

        //horizontalMove = joystick.Horizontal * runSpeed;

        if(joystick.Horizontal >= .2f)
        {
            horizontalMove = runSpeed;
            animator.SetBool("Parado", false);
            animator.SetBool("Andando", true);

        } else if (joystick.Horizontal <= -.2f)
        {
            horizontalMove = -runSpeed;
            animator.SetBool("Parado", false);
            animator.SetBool("Andando", true);
        } else
        {
            horizontalMove = 0f;
            animator.SetBool("Andando", false);
            animator.SetBool("Parado", true);
            
        }

        float verticalMove = joystick.Vertical;

        /*animator.SetFloat("Speed", Mathf.Abs(horizontalMove));*/

        if (verticalMove >= .5f)
        {
            jump = true;
            /*animator.SetBool("IsJumping", true);*/
        }

        if (verticalMove <= -.5f)
        {
            crouch = true;
        }
        else
        {
            crouch = false;
        }
    }

    /*public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }*/

    /*public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }*/

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}