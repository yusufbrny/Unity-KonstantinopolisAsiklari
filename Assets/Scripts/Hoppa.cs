using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hoppa : MonoBehaviour
{
	public GameObject HoppaPanel;


	private void Start()
	{
		HoppaPanel.SetActive(false);
		Time.timeScale = 1;
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Hoppa")
		{
			HoppaPanel.SetActive(true);
			Time.timeScale = 0;
		}
	}
}
