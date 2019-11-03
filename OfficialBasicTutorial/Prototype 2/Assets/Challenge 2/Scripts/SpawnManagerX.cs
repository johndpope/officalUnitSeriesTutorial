﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    private bool testBool = true;
    private int testSec = 1;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        Invoke("SpawnRandomBall", startDelay);
    }

    private void Update()
    {
        if(testBool)
        {
            StartCoroutine(Test());
        }
    }

    private IEnumerator Test()
    {
        testBool = false;
        Debug.Log(testSec++);
        yield return new WaitForSeconds(1);
        testBool = true;
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        testSec = 1;
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[0], spawnPos, ballPrefabs[0].transform.rotation);
        startDelay = Random.Range(1, 5);
        Invoke("SpawnRandomBall", startDelay);
    }

}
