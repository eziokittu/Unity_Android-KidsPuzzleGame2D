using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] enemies;

    //private float enemySpawnHeight = 8f;
    private float enemySpawnWidth = 8.5f;

    //bool stopSpawning = false;

    void FixedUpdate()
    {
        enemySpawnWidth = transform.position.y + 8.5f;
        Debug.Log("y="+transform.position.y);
    }

    void Start()
    {
        StartCoroutine(SpawnAnEnemy(enemySpawnWidth)); 
    }

    IEnumerator SpawnAnEnemy(float posy)
    {
        Instantiate(enemies[Random.Range(0, 2)], new Vector3(Random.Range(-enemySpawnWidth, enemySpawnWidth), posy, 0), transform.rotation);
        yield return new WaitForSeconds(1);
    }
}
