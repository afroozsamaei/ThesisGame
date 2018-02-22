using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {

    public GameObject[] inventoryItems = new GameObject[4];

    private AudioSource source;
    public AudioClip victory;

    void Start () {

        source = GetComponent<AudioSource>();

        for (int i = 0; i < inventoryItems.Length; i++)
        {
            inventoryItems[i].SetActive(false);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pass1"))
        {
            source.PlayOneShot(victory, 1f);
            inventoryItems[0].SetActive(true);
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Pass2"))
        {
            source.PlayOneShot(victory, 1f);
            inventoryItems[1].SetActive(true);
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Pass3"))
        {
            source.PlayOneShot(victory, 1f);
            inventoryItems[2].SetActive(true);
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Pass4"))
        {
            source.PlayOneShot(victory, 1f);
            inventoryItems[3].SetActive(true);
            other.gameObject.SetActive(false);
        }
    }

 
}
