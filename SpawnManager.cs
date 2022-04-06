using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xSpwan = 15.0f;
    private float zSpawn = 16;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 0.8f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int index = Random.Range(0, 3);
        float animalX = Random.Range(-xSpwan, xSpwan);
        Instantiate(animalPrefabs[index], new Vector3(animalX, transform.position.y, zSpawn), animalPrefabs[index].transform.rotation);
    }
}
