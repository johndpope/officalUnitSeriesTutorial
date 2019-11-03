using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private int animalIndex;
    public Vector3 spawnLoction;
    private float spawnRangeX = 10;
    private float spamnRangeZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnLoction = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spamnRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnLoction, animalPrefabs[animalIndex].transform.rotation);
    }
}
