using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour
{
    public float ammoGiven;
    GunScript ammo;
    public AudioSource collected;

    void Start()
    {
        ammo =  FindObjectOfType<GunScript>(); 
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("Pendejada Agarrada");
            ammo.Magazine = ammo.Magazine + ammoGiven;
            collected.Play();
            Destroy(gameObject);
        }
    }
    
}
