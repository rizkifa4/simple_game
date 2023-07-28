using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public int playerSpeed;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    public int jumppower;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerSpeed = 2;
        jumppower = 5;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            playerRb.velocity = new Vector2(playerSpeed, playerRb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            playerRb.velocity = new Vector2(-playerSpeed, playerRb.velocity.y);
        }
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, 5);
        }
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
}
