using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlappyBird_Score : MonoBehaviour
{
    public static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponentInChildren<Text>().text = score.ToString();
    }
}
