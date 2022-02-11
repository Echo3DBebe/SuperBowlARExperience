using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGoalTrigger : MonoBehaviour
{   
    [SerializeField]
    public AudioSource cheeringSource;

    void OnTriggerEnter(Collider other)
    {
        cheeringSource.Play();
        print("Touchdown!");
    }
}
