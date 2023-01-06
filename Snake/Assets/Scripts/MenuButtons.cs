
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Snake_1");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
