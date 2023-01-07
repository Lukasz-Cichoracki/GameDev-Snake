using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public static GameObject pauseScreen;
    public static Snake snake;

    private void Awake()
    {
        pauseScreen = GameObject.Find("pauseScreen");
        snake = FindObjectOfType<Snake>();
        ResumeGame();
    }
    private void Update()
    {
        if(DeathScreen.deathScreen.activeInHierarchy == false && pauseScreen.activeInHierarchy == false && Input.GetKeyDown(KeyCode.Escape))
            PauseGame();
        else if(pauseScreen.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape))
            ResumeGame();

    }

    public static void PauseGame()
    {
        Time.timeScale = 0f;
        pauseScreen.SetActive(true);
    }

    public static void ResumeGame()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = snake.snakeSpeed;
    }

    public static void GoToMenu()
    {
        SceneManager.LoadScene("Snake_Menu");
    }


}
