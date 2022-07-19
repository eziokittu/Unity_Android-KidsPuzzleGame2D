using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LittlePlanets_RandomPatrol : MonoBehaviour
{
    [HideInInspector] public float aspect;
    [HideInInspector] public float worldWidth;
    [HideInInspector] public float worldHeight;
    [HideInInspector] public float planetSize;
    public GameObject gameOverPanel;
    public float minSpeed = 0.25f; 
    public float maxSpeed = 1.25f; 
    float moveSpeed = 0.66f; 
    public float secondsToMaxDifficulty = 90.0f; // 1.5 minute to reach max difficulty
    
    Vector2 targetPosition;

    void Awake()
    {
        GetComponent<AnchorGameObject>().enabled = false;
        planetSize = transform.localScale.x;

        aspect = (float)Screen.width / Screen.height;
        worldHeight = Camera.main.orthographicSize * 2;
        worldWidth = worldHeight * aspect;

        // Debug.Log("World width = " + worldWidth + ", World height = " + worldHeight);
    }

    void Start()
    {
        targetPosition = GetRandomPosition();
        GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

    void Update()
    {
        if ((Vector2)transform.position != targetPosition)
        {
            moveSpeed = Mathf.Lerp(minSpeed, maxSpeed, GetDifficultyPercent());
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
        else if ((Vector2)transform.position == targetPosition)
        {
            targetPosition = GetRandomPosition();
        }
    }

    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(-worldWidth / 2 + planetSize / 2, worldWidth / 2 - planetSize / 2);
        float randomY = Random.Range(-worldHeight / 2 + planetSize / 2, worldHeight / 2 - planetSize / 2);
        // Debug.Log("Random width = " + randomX + ", Random height = " + randomY);
        return new Vector2(randomX, randomY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "LittlePlanet")
        {
            Debug.Log("Game Over - " + collision.name + " hit");
            gameOverPanel.SetActive(true);
        }
    }

    float GetDifficultyPercent()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);
    }
}
