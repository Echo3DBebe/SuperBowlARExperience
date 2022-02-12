using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGoalTrigger : MonoBehaviour
{

    [SerializeField]
    private Rigidbody football;

    [SerializeField]
    private float footballSpeed;

    [SerializeField]
    public AudioSource cheeringSource;

    private Touch tapToThrow;
    private Vector3 startingPosition;
    private Quaternion startingRotation;


    void Start()
    {
        startingPosition = football.transform.position;
        startingRotation = football.transform.rotation;
    }

    void Update()
    {
        // To play on your Android device, comment out this Input. Hit Space bar to fire.
        // if (Input.GetKeyDown(KeyCode.Space))
        
        // To play on keyboard, comment out this Input. 
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {

            football.AddForce(-football.transform.right * footballSpeed, ForceMode.VelocityChange);
            print("Shooting the shot");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        cheeringSource.Play();
        print("Touchdown!");

        football.transform.position = startingPosition;
        football.transform.rotation = startingRotation;

        //  football.transform.position = footballSpawn.position;
        football.velocity = Vector3.zero;
    }
}
