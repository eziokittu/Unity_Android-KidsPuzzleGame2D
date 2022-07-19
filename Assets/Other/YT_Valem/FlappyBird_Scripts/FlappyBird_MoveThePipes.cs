using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird_MoveThePipes : MonoBehaviour
{
    public float pipeMoveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * pipeMoveSpeed * Time.deltaTime;
    }
}
