using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class RoadManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject roadPrefabs;
    public GameObject roadSpawn;
    
    public void SpawnRoad()
    {
        Vector3 spawnPos = new Vector3(0,0, roadSpawn.transform.position.z);
        Instantiate(roadPrefabs, spawnPos, roadPrefabs.transform.rotation);
    }
}
