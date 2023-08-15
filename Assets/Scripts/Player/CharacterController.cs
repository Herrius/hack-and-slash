using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    private float horizontalMove = 0f;
    private float verticalMove = 0f;
    public float runSpeedHorizontal = 3f;
    public float runSpeedVertical = 3f;

    public float runSpeed = 1.25f;
    public float jumpSpeed = 3f;
    public bool isAttacking = false;

    public Button attackButton;
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
            animator.SetFloat("Speed", 1);
            if(verticalMove > 0.5)
            {
                animator.SetFloat("Vertical", verticalMove);
            }
        }
        else
        {
            if (horizontalMove < 0 || verticalMove <0)
            {
                animator.SetBool("Run", true);
                animator.SetFloat("Horizontal", horizontalMove);
                animator.SetFloat("Speed", 1);
                if(verticalMove < -0.5)
                {
                    animator.SetFloat("Vertical", verticalMove);
                }
            }
            else
            {
                animator.SetBool("Run", false);
                animator.SetFloat("Speed", 0);
            }
        }
        if (CheckGround.isGrounded == false)
        {
            animator.SetBool("Run", false);
        }
        if (CheckGround.isGrounded == true)
        {
        }
        ataque();
    }
    void FixedUpdate()
    {
        verticalMove = joystick.Vertical * runSpeedVertical;
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;
        transform.position+=new Vector3(horizontalMove,0, 0) * Time.deltaTime * runSpeed;
        transform.position+=new Vector3(0,verticalMove, 0) * Time.deltaTime * jumpSpeed;

    }
    public void ataque()
    {
        if (attackButton.interactable && Input.GetButtonDown("Fire1"))
        {
            isAttacking = true;
            animator.SetBool("Attack", true);
        }
        else
        {
            isAttacking = false;
            animator.SetBool("Attack", false);
        }
    }

}
