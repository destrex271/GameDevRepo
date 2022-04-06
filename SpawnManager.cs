using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float timeInterval = 1.0f;
    private float time = 1.0f;
    private float zSpawn = 16;
    // Update is called once per frame
    void FixedUpdate()
    {
        int index = Random.Range(0, 3);
        int animalX = Random.Range(-13, 13);
        if (time <= 0)
        {
            Instantiate(animalPrefabs[index], new Vector3(animalX, transform.position.y, zSpawn), animalPrefabs[index].transform.rotation);
            time = timeInterval;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
