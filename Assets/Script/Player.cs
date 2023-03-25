using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public int moveSpeed;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    public int jumppower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 2;
        jumppower = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        // if (Input.GetKey(KeyCode.A))
        // {
        //     rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        // }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
       
        // else
        // {
        //     rb.velocity = new Vector2(0, rb.velocity.y);
        // }
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }
        // rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

       
    }
}
