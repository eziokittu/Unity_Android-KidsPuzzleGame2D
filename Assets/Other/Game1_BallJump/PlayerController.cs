using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f;

    private float screenWidth;
    private float x;

    private void Awake()
    {
        screenWidth = Screen.width;
        //Debug.Log("Screen Width = " + screenWidth);
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                //Debug.Log("Touch position x = " + touchPosition.x + ", Ball position x = " + transform.position.x);
                
                if (touchPosition.x >= transform.position.x)
                {
                    x = Random.Range(0.1f, 0.5f);
                }
                else if (touchPosition.x < transform.position.x)
                {
                    x = Random.Range(-0.5f, -0.1f);
                }

                this.GetComponent<Rigidbody2D>().velocity = new Vector2(x,1) * jumpForce;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log(col.gameObject.name);

        if (col.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player is dead!");
        }
    }
}
