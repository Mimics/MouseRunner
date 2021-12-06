using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSpawner : MonoBehaviour
{
    public GameObject[] cheese_mt;

    public float minTime;
    public float maxTime;


    void Start()
    {
        InvokeRepeating("Cheese_spawner", 1, Random.Range(minTime, maxTime));
    }

    
    void Update()
    {
        
    }

    public void Cheese_spawner()
    {
        GameObject obj = cheese_mt[Random.Range(0,cheese_mt.Length)];
        Instantiate(obj,transform.position, Quaternion.identity);
    }
}
