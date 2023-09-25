using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject Player;

    public bool IsPaused; 

 void Start()
    {
        pauseMenu.SetActive(false);
    }

 void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(IsPaused)
            {

                ResumeGame();
            }
            else
            {
                Pausegame();

            }
        }
    }
    public void Pausegame()
    {
        Player.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
    public void ResumeGame()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Player.SetActive(true);

        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
