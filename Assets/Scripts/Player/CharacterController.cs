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
        }
        else
        {
            if (horizontalMove < 0 || verticalMove <0)
            {
                animator.SetBool("Run", true);
                animator.SetFloat("Horizontal", horizontalMove);
                animator.SetFloat("Speed", 1);
            }
            else
            {
                animator.SetBool("Run", false);
                animator.SetFloat("Speed", 0);
            }
        }
    }

    void FixedUpdate()
    {
        verticalMove = joystick.Vertical * runSpeedVertical;
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;
        transform.position+=new Vector3(horizontalMove,verticalMove, 0) * Time.deltaTime * runSpeed;
    }
}
