using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public static GameObject deathScreen;

    private void Awake()
    {
        deathScreen = GameObject.Find("deathScreen");
        DisableDeathScreen();
    }

    private void Update()
    {
        if (deathScreen.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("Snake_1");
    }
    public static void SetDeathScreenActive()
    {
        Time.timeScale = 0f;
        deathScreen.SetActive(true);
    }
    public static void DisableDeathScreen()
    {
        deathScreen.SetActive(false);
        Time.timeScale = 1f;
    }
}
