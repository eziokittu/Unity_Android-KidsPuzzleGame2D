using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerToFollow;
    public Transform enviroment;
    public Transform gameManager;

    private void Update()
    {
        if (playerToFollow.position.y >= transform.position.y)
        {
            transform.position = new Vector3(0f, playerToFollow.position.y, -10f);
            
            enviroment.position = new Vector3(enviroment.position.x, playerToFollow.position.y, enviroment.position.z);
            gameManager.position = new Vector3(gameManager.position.x, playerToFollow.position.y, gameManager.position.z);
        }
    }
}
