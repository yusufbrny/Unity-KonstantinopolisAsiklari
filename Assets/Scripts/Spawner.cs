using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float maxTime = 1;
    private float timer = 0;
    public GameObject spawnObject;
    public float height;
    public float width = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(spawnObject);
        newpipe.transform.position = transform.position + new Vector3(Random.Range(-width, width), Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
          GameObject newpipe =  Instantiate(spawnObject);
            newpipe.transform.position = transform.position + new Vector3(Random.Range(-width, width), Random.Range(-height, height), 0);
            Destroy(newpipe, 20);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
