using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class TextUpdate : MonoBehaviour
{

    public TextMeshProUGUI cointext;
    public SoOpenTrigger numberOfCoins;
    public AudioSource audioSource;
    public AudioClip audioClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {


    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player")
        {
            audioSource.PlayOneShot(audioClip, 1.0f);
            numberOfCoins.value += 1;
            gameObject.SetActive(false);
            
           // Debug.Log("Vaule Update");

        }

    }

}
