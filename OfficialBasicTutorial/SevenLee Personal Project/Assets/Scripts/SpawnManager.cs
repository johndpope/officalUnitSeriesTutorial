using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Vector3 spawnPos;
    private int otherCount;
    public GameObject[] otherObjects;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        otherCount = GameObject.FindGameObjectsWithTag("OtherObject").Length;
        if(otherCount <=0)
        {
            spawnPos = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
            Instantiate(otherObjects[(int)Random.Range(0, 3)], spawnPos,Quaternion.identity);
        }
    }
}
