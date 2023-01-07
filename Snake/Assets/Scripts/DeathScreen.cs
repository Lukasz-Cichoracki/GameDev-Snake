using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public static GameObject deathScreen;
    public static Snake snake;

    private void Awake()
    {
        snake = FindObjectOfType<Snake>();
        deathScreen = GameObject.Find("deathScreen");
        DisableDeathScreen();
    }

    private void Update()
    {
        if (deathScreen.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("Snake_1");
        else if (deathScreen.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Snake_Menu");

    }
    public static void SetDeathScreenActive()
    {
        Time.timeScale = 0f;
        deathScreen.SetActive(true);
    }
    public static void DisableDeathScreen()
    {
        deathScreen.SetActive(false);
        Time.timeScale = snake.snakeSpeed;
    }
}
