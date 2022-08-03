using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_menu : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject HelpMessage;


    void Start()
    {
        PauseMenuUI.SetActive(false);
        HelpMessage.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameIsPaused = !GameIsPaused;
            if (GameIsPaused)
                Pause();
            else
                Resume();
        }
            
    }

    public void Pause()
    {
        if (SceneManager.GetActiveScene().buildIndex != 11)
        {
            Time.timeScale = 0f;
        }
        PauseMenuUI.SetActive(true);
        GameIsPaused = true;
        HelpMessage.SetActive(false);
    }

    public void Resume()
    {
        if (SceneManager.GetActiveScene().buildIndex != 11)
        {
            Time.timeScale = 1f;
        }
        PauseMenuUI.SetActive(false);
        GameIsPaused = false;
    }

    public void MainMenu()
    {
        GameIsPaused = false;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
