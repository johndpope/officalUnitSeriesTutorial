using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPfb;
    private float spawnRange = 9;
    float spawnPosX;
    float spawnPosZ;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPfb, GenerateSpawnPosition(), enemyPfb.transform.rotation);
    }


    Vector3 GenerateSpawnPosition()
    {
        spawnPosX = Random.Range(-spawnRange, spawnRange);
        spawnPosZ = Random.Range(-spawnRange, spawnRange);
        return new Vector3(spawnPosX,  0, spawnPosZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
