using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelScript : MonoBehaviour
{

    public float fuel;
    public Image image;
    private CharacterController controller;
    public GameObject GameOverMenu;

    void Start()
    {
        fuel = 0;
        GameOverMenu.SetActive(false);
    }


    void Update()
    {
        fuel += Time.deltaTime * 0.035f;

        image.fillAmount = fuel;

        if (fuel < 0)
        {
            fuel = 0;
        }

        if (fuel > 1)
        {
            Time.timeScale = 0;
            fuel = 1;
            GameOverMenu.SetActive(true);
        }
    }
}
