using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private float horizontalMove = 0f;
    private float verticalMove = 0f;
    public float runSpeedHorizontal = 3f;
    public float runSpeedVertical = 3f;

    public float runSpeed = 1.25f;
    public float jumpSpeed = 3f;

    public Joystick joystick;
    public Animator animator;
    private Rigidbody2D playerRb;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (horizontalMove > 0 || verticalMove > 0)
        {
            animator.SetBool("Run", true);
            animator.SetFloat("Horizontal", horizontalMove);
            animator.SetFloat("Vertical", verticalMove);
            animator.SetFloat("Speed", 1);
        }
        else
        {
            if (horizontalMove < 0 || verticalMove <0)
            {
                animator.SetBool("Run", true);
                animator.SetFloat("Horizontal", horizontalMove);
                animator.SetFloat("Vertical", verticalMove);
                animator.SetFloat("Speed", 1);
            }
            else
            {
                animator.SetBool("Run", false);
                animator.SetFloat("Speed", 0);
            }
        }
        if (CheckGround.isGrounded == false)
        {
            //animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (CheckGround.isGrounded == true)
        {
            //animator.SetBool("Jump", false);
            //animator.SetBool("DoubleJump", false);
            //animator.SetBool("Falling", false);
        }

    }

    void FixedUpdate()
    {
        verticalMove = joystick.Vertical * runSpeedVertical;
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;
        transform.position+=new Vector3(horizontalMove,0, 0) * Time.deltaTime * runSpeed;
        transform.position+=new Vector3(0,verticalMove, 0) * Time.deltaTime * jumpSpeed;

    }
    public void Jump()
    {
        if (CheckGround.isGrounded)
        {
            canDoubleJump = true;
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpSpeed);
        }
        else
        {
            if (canDoubleJump)
            {
                animator.SetBool("DoubleJump", true);
                playerRb.velocity = new Vector2(playerRb.velocity.x, doubleJumpSpeed);
                canDoubleJump = false;
            }
        }
    }
}
