using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreTextScript : MonoBehaviour
{
    public Text playerText;
    public Text bossText;
    public static int coinAmount;
    public static float bossCoinamount;
    public GameObject Panel;


    void Start()
    {
        bossCoinamount = 20f;
        Panel.SetActive(false);
    }


    void Update()
    {
        playerText.text = "Topladığın Altın = " + coinAmount.ToString();
        bossText.text = "Patronun Topladığı Altın = " + (int) bossCoinamount;
        bossCoinamount += Time.deltaTime * 0.3f;

        if(coinAmount >= bossCoinamount)
        {
            Panel.SetActive(true);
        }
    }
}
