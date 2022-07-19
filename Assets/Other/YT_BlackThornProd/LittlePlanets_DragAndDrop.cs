using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittlePlanets_DragAndDrop : MonoBehaviour
{
    bool moveAllowed;
    Collider2D col;

    private void Start()
    {
        col = GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began )
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider)
                {
                    moveAllowed = true;
                }
            }
            if (touch.phase == TouchPhase.Moved)
            {
                if (moveAllowed == true)
                {
                    transform.position = touchPosition;
                }
            }
            if (touch.phase == TouchPhase.Ended)
            {
                moveAllowed = false;
            }
        }
    }
}
