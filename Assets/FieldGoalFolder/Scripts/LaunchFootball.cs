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

    private void Start()
    {
        footballSpeed = 300f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        //if (Input.touchCount > 0)
        {
            var newFootball = Instantiate(football, footballSpawn.position, footballSpawn.rotation);
            newFootball.AddForce(footballSpawn.forward * footballSpeed);

            print("Touchdown!");
        }
    }
}
