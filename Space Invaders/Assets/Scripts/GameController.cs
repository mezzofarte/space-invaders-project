using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static bool isPaused = false;
    public Player player;
    public GameObject pauseMenu;
    public GameObject gameOver;

    void Start()
    {
        pauseMenu.SetActive(false);
        gameOver.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (player.lives == 0)
        {
            GameOver();
        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log(player.lives);
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
