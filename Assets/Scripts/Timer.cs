using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    private CharacterController controller;
    public GameObject WinPanel;
    public Text TimerText;

    void Start()
    {
        WinPanel.SetActive(false);
    }


    void Update()
    {
        time -= Time.deltaTime * 1f;

        TimerText.text = "Kalan Zaman = " + (int) time;

        if (time < 0)
        {
            time = 0;
            WinPanel.SetActive(true);
            Time.timeScale = 0;
        }

        if (time > 60)
        {
            Time.timeScale = 0;
            time = 60; 
        }
    }
}
