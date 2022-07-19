using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float jumpForce = 8f;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private bool onGround;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        rb.velocity = new Vector2(3, rb.velocity.y);
        if (Input.GetMouseButtonDown(0) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, 1*jumpForce);
        }
    }
}
