using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialouge : MonoBehaviour
{

    public GameObject nextSceneButton;
    public GameObject ContinueButton;

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public float typingSpeed;

    private int index;


    void Start()
    {
        StartCoroutine(Type());
        nextSceneButton.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            ContinueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentences()
    {

        ContinueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            nextSceneButton.SetActive(true);
            ContinueButton.SetActive(false);
        }
    }
}
