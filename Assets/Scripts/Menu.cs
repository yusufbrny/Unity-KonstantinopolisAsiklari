using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private int number;

    public GameObject brainGamePanel;

    private void Start()
    {
        brainGamePanel.SetActive(false);
    }

    public void SceneT()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + number);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("CutScenes", LoadSceneMode.Single);
    }

    public void Episode1()
    {
        SceneManager.LoadScene("StartLevel", LoadSceneMode.Single);
    }

    public void PlayBrainGame()
    {
        brainGamePanel.SetActive(true);
    }

    public void Duello()
    {
        SceneManager.LoadScene("Duello", LoadSceneMode.Single);
    }

    public void Finish()
    {
        SceneManager.LoadScene("Finish", LoadSceneMode.Single);
    }
}
