using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilScript : MonoBehaviour
{
    public FuelScript fuelcode;
    public GameObject fuelImage;

    void Start()
    {
        fuelcode = fuelImage.GetComponent<FuelScript>();
    }


    void Update()
    {
        
    }

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Oil")
		{
            fuelcode.fuel -= 1;
        }
	}
}
