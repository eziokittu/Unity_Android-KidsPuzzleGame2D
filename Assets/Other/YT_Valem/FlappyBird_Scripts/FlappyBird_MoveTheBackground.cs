using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird_MoveTheBackground : MonoBehaviour
{
    private BoxCollider2D col;
    private Rigidbody2D rb;

    private float width;
    public float scrollSpeed = -2f;

    private void Start()
    {
        col = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = col.size.x;
        col.enabled = false;

        rb.velocity = new Vector2(scrollSpeed, 0);
    }

    private void Update()
    {
        if (transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }
}
