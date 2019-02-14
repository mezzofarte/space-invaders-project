using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static bool isPaused = false;
    public Player player;
    public Enemy enemy;
    public GameObject pauseMenu;
    public GameObject gameOver;
    public GameObject gameWin;

    void Start()
    {
        pauseMenu.SetActive(false);
        gameOver.SetActive(false);
        gameWin.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.getLives() == 0)
        {
            GameOver();
        }

        if (enemy.getLives() == 0){
            GameWin();
        }

        else if (false)
        {
            GameWin();
        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {
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

    public void GameWin()
    {
        gameWin.SetActive(true);
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
        Debug.Log("what");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
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
