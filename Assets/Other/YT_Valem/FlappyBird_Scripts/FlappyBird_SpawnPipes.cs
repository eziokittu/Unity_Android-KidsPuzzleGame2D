using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird_SpawnPipes : MonoBehaviour
{
    public float maxTime = 2.5f;
    public GameObject[] pipes;
    public float height;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject newPipe = Instantiate(pipe);
        //newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            int whichPipe = Random.Range(0, 3000);
            if (whichPipe < 1800) whichPipe = 0;
            else if (whichPipe >= 1800 && whichPipe < 2600) whichPipe = 1;
            else whichPipe = 2;

            GameObject newPipe = Instantiate(pipes[whichPipe]);

            if (whichPipe == 0) newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            else if (whichPipe == 1) newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height*2, height*2), 0);
            else if (whichPipe == 2) newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height/2, height/2), 0);
            Destroy(newPipe, 10f);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
