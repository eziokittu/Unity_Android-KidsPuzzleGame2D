using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittlePlanets_CreateColourfulPlanets : MonoBehaviour
{
    [HideInInspector] public float aspect;
    [HideInInspector] public float worldWidth;
    [HideInInspector] public float worldHeight;
    [HideInInspector] public float planetSize;

    public GameObject planetToReplicate;
    public int noOfPlanets = 6;

    private GameObject[] arrayOfPlanets;

    private void Awake()
    {
        planetSize = planetToReplicate.transform.localScale.x;

        aspect = (float)Screen.width / Screen.height;
        worldHeight = Camera.main.orthographicSize * 2;
        worldWidth = worldHeight * aspect;
        for (int i = 0; i < noOfPlanets; i++)
        {
            Instantiate(planetToReplicate, randomSpawnPosition(), transform.rotation);
        }

        arrayOfPlanets = GameObject.FindGameObjectsWithTag("LittlePlanet");
    }

    private void Start()
    {
        for (int i = 0; i < noOfPlanets; i++)
        {
            arrayOfPlanets[i].GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }

    private Vector2 randomSpawnPosition()
    {
        float randomX = Random.Range(-worldWidth / 2 + planetSize / 2, worldWidth / 2 - planetSize / 2);
        float randomY = Random.Range(-worldHeight / 2 + planetSize/2, worldHeight / 2 - planetSize / 2);
        return new Vector2(randomX, randomY);
    }
}
