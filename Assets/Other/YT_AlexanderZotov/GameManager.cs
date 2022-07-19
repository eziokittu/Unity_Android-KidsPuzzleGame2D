using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject picturesParent;
    public GameObject panelYouWin;
    public bool gameWon;
    private Transform[] pictures;
    // counting if all the pictures are aligned.

    [SerializeField]
    private int count;

    void Awake()
    {
        gameWon = false;

        if (panelYouWin != null)
        {
            panelYouWin.SetActive(false);
        }
        else
        {
            Debug.Log("The panel for 'You Win' Text is missing OR wrong panel GAMEOBJECT added.\n Add it in the inspector tab.");
        }

        pictures = picturesParent.GetComponentsInChildren<Transform>();
    }

    private void Start()
    {
        // re arrange all the pictures to any random ordered orientation
        for (int i=1; i<pictures.Length; i++) // i=0 is for picture parent itself
        {
            int x= Random.Range(1, 3);

            //while (x == 0) // so that no picture gets to be perfectly aligned
            //{
            //    x = Random.Range(1, 3);
            //}
            
            pictures[i].eulerAngles += new Vector3(0.0f, 0.0f, x*90.0f);
        }

        for (int i = 0; i < pictures.Length; i++) // i=0 is for picture parent itself
        {
            Debug.Log("Z Rotation for - " + pictures[i].name + " : " + pictures[i].eulerAngles.z);
        }

    }

    // Update is called once per frame
    void Update()
    {
        count = 0; // count is not 0 because the 1st element is the parent that is 8+1 = 9 pictures to iterate
        foreach (Transform pic in pictures)
        {
            if (pic.rotation.eulerAngles.z == 0) count++;
        }

        //Debug.Log("Number of pictures : " + pictures.Length + " , Count : " + count);
        if (count == pictures.Length) gameWon = true;

        if (gameWon == true) panelYouWin.SetActive(true);
    }

    // Loads the next puzzle image and hides the older image
    public void LoadNextImage()
    {

    }
}
