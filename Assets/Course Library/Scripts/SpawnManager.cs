using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject[] obstaclePrefabs;
    public GameObject spawnObstacle;
    private float xRange = 9;
    public float spawnDelay=5;

   private void SpawnObstacle()
    {
        int indexAlea = Random.Range(0, obstaclePrefabs.Length);
        Vector3 spawnPoint = new Vector3(Random.Range(-xRange, xRange), 0, spawnObstacle.transform.position.z);
        Instantiate(obstaclePrefabs[indexAlea], spawnPoint, obstaclePrefabs[indexAlea].transform.rotation);
        Invoke("SpawnObstacle", spawnDelay);
    }
    private void Start()
    {
            Invoke("SpawnObstacle", spawnDelay);
    }

    void Update()
    {
            
    }
}
