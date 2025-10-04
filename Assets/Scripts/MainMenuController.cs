using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayMadDriver()
    {
        SceneManager.LoadScene("MadDriver");
    }

    public void PlayFly()
    {
        SceneManager.LoadScene("FlyLikeABird");
    }

    public void PlaySumo()
    {
        SceneManager.LoadScene("Sumo");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game pressed!");
        Application.Quit();
    }
}
