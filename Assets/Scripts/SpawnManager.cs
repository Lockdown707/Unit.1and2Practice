using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float spawnRangeZ = 20;
    public float spawnPosY = 20;
    public float spawnPosXMin = 20;
    public float spawnPosXMax = 50;
    public float startDelay = 2;
    public float SpawnInterval = 1.5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SpawnRandomAnimal();
        }
    }
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnPosXMin, spawnPosXMax), spawnPosY, Random.Range(-spawnRangeZ, spawnRangeZ));
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
