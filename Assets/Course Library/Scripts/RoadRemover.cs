using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadRemover : MonoBehaviour
{
    private RoadManager roadManager;
    // Start is called before the first frame update
    void Start()
    {
        roadManager = GameObject.Find("RoadManager").GetComponent<RoadManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {

        Destroy(other.gameObject);
        if (other.gameObject.CompareTag("Road"))
        {
            roadManager.SpawnRoad();
        }
       
    }
}
