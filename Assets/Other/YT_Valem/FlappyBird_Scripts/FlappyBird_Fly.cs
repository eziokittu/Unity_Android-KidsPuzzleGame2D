using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird_Fly : MonoBehaviour
{
    private Rigidbody2D rb;
    public FlappyBird_GameManager gm;
    public float jumpForce = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(0, 1 * jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gm.GameOver();
    }
}
