using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSound : MonoBehaviour
{
    public AudioSource audioSource;

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collision")
        {
            audioSource.Play();
        }
    }
}
