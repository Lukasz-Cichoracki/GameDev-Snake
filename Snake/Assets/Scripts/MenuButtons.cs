
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject optionsMenu;
    
    public void Play()
    {
        SceneManager.LoadScene("Snake_1");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Options()
    {
        optionsMenu.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
