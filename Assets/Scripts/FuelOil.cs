using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelOil : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
