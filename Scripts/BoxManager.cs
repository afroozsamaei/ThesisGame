using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxManager : MonoBehaviour {

    public GameObject[] boxes = new GameObject[numItems];
    public const int numItems = 4;
    public static bool pickedUpBoxes;

    private AudioSource source;
    public AudioClip pickUp;


    void Start () {

        source = GetComponent<AudioSource>();
        pickedUpBoxes = false;

        for (int i = 0; i < boxes.Length-1; i++)
        {
            boxes[i].SetActive(true);
        }

        boxes[3].SetActive(true);

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BoxPickUp"))
        {
            source.PlayOneShot(pickUp, 1f);
            boxes[3].SetActive(true);
            other.gameObject.SetActive(false);
            pickedUpBoxes = true;
        }
    }
}
