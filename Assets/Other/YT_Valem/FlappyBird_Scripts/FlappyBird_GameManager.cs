using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird_GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject startGamePanel;
    public GameObject scorePanel;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene("YT_Valem");
    }

    public void StartGame()
    {
        startGamePanel.SetActive(false);
        scorePanel.SetActive(true);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}