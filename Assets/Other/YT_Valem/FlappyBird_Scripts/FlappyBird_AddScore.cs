using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird_AddScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FlappyBird_Score.score++;
    }
}
