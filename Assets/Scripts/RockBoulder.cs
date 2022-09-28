using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBoulder : MonoBehaviour
{
    public GameObject Boulder;
    public AudioSource BoulderSound;
    public AudioSource BoulderDestroy;

    void Start()
    {
        
        Boulder.SetActive(false);
    }

   
    void OnTriggerEnter2D (Collider2D Col)
    {
        if (Col.gameObject.tag == ("Player"))
        {
            Boulder.SetActive(true);
            BoulderSound.Play();
            Destroy(Boulder, 8f);
            BoulderDestroy.Play();
            Destroy(gameObject);
        }
    }
}
