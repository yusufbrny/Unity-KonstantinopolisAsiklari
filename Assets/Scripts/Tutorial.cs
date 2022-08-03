using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject Object;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Object.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Object.SetActive(false);
    }

}
