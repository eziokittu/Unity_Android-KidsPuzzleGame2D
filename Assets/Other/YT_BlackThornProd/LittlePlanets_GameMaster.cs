using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LittlePlanets_GameMaster : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("YT_BlackThornProd_Game");
    }

    public void QuitGame()
    {
        Debug.Log("Application has beed QUIT");
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("YT_BlackThornProd_MainMenu");
    }
}
