using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activarAtaque : MonoBehaviour
{
    public Animator animator;
    public Button attackButton;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (attackButton.interactable && Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("Attack", true);
        }
        else
        {
            animator.SetBool("Attack", false);
        }
    }

    public void ataque()
    {
        if (attackButton.interactable && Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("Attack", true);
        }
        else
        {
            animator.SetBool("Attack", false);
        }
    }
}
