using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheering : MonoBehaviour
{   
    [SerializeField]
    private AudioSource cheeringSource;

    void OnTriggerEnter(Collider other)
    {
        cheeringSource.Play();
    }
}
