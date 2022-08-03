using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    private void Start()
    {

    }

  void OnTriggerEnter2D(Collider2D col)
    {
        scoreTextScript.coinAmount += 1;
        Destroy(gameObject);
    }
}
