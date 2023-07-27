using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float horizontalMove = 0;
    [SerializeField] private float verticalMove = 0;
    [SerializeField] private float runSpeedHorizontal = 3f;
    [SerializeField] private float runSpeedVertical = 3f;
    public float runSpeed = 0;
    private Rigidbody2D playerRb;
    public Joystick joystick;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        verticalMove = joystick.Vertical * runSpeedVertical;
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;
        transform.position += new Vector3(horizontalMove, verticalMove, 0) * Time.deltaTime * runSpeed; 
    }
}
