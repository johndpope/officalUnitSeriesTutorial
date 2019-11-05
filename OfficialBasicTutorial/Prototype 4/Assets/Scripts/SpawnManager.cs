using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPfb;
    public GameObject powerPfb;
    private float spawnRange = 9;
    float spawnPosX;
    float spawnPosZ;
    private int enemyCount;
    public int waveNumber = 1;


    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        Instantiate(powerPfb, GenerateSpawnPosition(), powerPfb.transform.rotation);
    }


    Vector3 GenerateSpawnPosition()
    {
        spawnPosX = Random.Range(-spawnRange, spawnRange);
        spawnPosZ = Random.Range(-spawnRange, spawnRange);
        return new Vector3(spawnPosX,  0, spawnPosZ);
    }

    void SpawnEnemyWave(int enemysToSpawn)
    {
        for (int i = 0; i < enemysToSpawn; i++)
        {
            Instantiate(enemyPfb, GenerateSpawnPosition(), enemyPfb.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindObjectsOfType<Enemy>().Length;
        if (enemyCount <= 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerPfb, GenerateSpawnPosition(), powerPfb.transform.rotation);
        }
    }
}
