using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager gameManager;
    private float turnSpeed = 100;
    private float horizontalInput;
    private float xRange = 8;
    public ParticleSystem explosionParticle;
    private GameObject carMesh;
    private float turnRange= 0.1f;
    private float slideSpeed = 10;
    public TrailRenderer[] TyreMarks;



    private void Start()
    {
        carMesh = GameObject.Find("Vehicule");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
       
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3( xRange,0,0 );
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, 0, 0);
        }
        transform.Translate(Vector3.right * horizontalInput  *slideSpeed* Time.deltaTime * (gameManager.isGameOn ? 1 : 0));
        /* transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);*/

        if(gameManager.isGameOn)
        turnAnim();


    }
    private void turnAnim()
    {
        if (horizontalInput == 0)
        {
            carMesh.transform.rotation = Quaternion.Slerp(carMesh.transform.rotation, Quaternion.identity, Time.deltaTime*2);
           /* stopEmmiter();*/
        }
        else if (carMesh.transform.rotation.y < turnRange && horizontalInput > 0)
        {
            carMesh.transform.Rotate(Vector3.up * 1 * Time.deltaTime * turnSpeed);
            /*startEmmiter();*/
        }
        else if (carMesh.transform.rotation.y > -turnRange && horizontalInput < 0)
        {
            carMesh.transform.Rotate(Vector3.up * -1 * Time.deltaTime * turnSpeed);
            /*startEmmiter();*/
        }
    }

   /* private void startEmmiter()
    {
        foreach(TrailRenderer T in TyreMarks)
        {
            T.emitting = true;
        }
    }
    private void stopEmmiter()
    {
        foreach (TrailRenderer T in TyreMarks)
        {
            T.emitting = false;
        }
    }*/

}
