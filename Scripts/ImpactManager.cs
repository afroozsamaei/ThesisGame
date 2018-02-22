using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactManager : MonoBehaviour {

    public static bool inWater;
    public static bool atDestination;

    private AudioSource source;
    public AudioClip crash;
    public AudioClip splash;
    public AudioClip destination;

    void Start () {
        inWater = false;
        atDestination = false;
 
        source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Objects"))
        {
            source.PlayOneShot(crash, 0.1f);
        }

        if (collision.gameObject.CompareTag("Water"))
        {
            inWater = true;
            source.PlayOneShot(splash, 1f);
        }
    }

    private void OnTriggerEnter(Collider other) { 

        
        if (other.gameObject.CompareTag("Destination"))
        {
            atDestination = true;
            source.PlayOneShot(destination, 0.5f);
            other.gameObject.SetActive(false);
        }
    }
}
