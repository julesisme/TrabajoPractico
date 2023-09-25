using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("MainGame");
    }

    public void ToMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
