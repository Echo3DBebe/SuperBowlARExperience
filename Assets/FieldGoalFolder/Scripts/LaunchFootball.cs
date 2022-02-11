using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchFootball : MonoBehaviour
{
    [SerializeField]
    private Transform footballSpawn;

    [SerializeField]
    private Rigidbody football;

    [SerializeField]
    private float footballSpeed;

    private Touch tapToThrow;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        //if (Input.touchCount > 0)
        {
           // Instantiates a new football when input is given
           // var newFootball = Instantiate(football, footballSpawn.position, footballSpawn.rotation);

            football.AddForce(footballSpawn.forward * footballSpeed, ForceMode.VelocityChange);
            print("Shooting the shot");
        }
    }
}
