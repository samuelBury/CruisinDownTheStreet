using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoForward : MonoBehaviour
{
    public float speedModifier;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Road"))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * gameManager.gameSpeed);
        }
        else
        {
            transform.Translate(Vector3.back * Time.deltaTime * gameManager.gameSpeed*speedModifier);
        }
       
    }
}
