using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public GameObject gameObjectOffset;
    // Start is called before the first frame update
    void Start()
    {
        offset = gameObjectOffset.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset ;

    }
}
