using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpSccript : MonoBehaviour
{
    public float ammoGiven;
    GunScript ammo;
    public GunScript power;
    public AudioSource collected;
    public AudioSource vibration;
    


    void Start()
    {
        ammo =  FindObjectOfType<GunScript>(); 
        vibration.Play();
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {  
            collected.Play();
            ammo.Magazine = ammo.Magazine + ammoGiven;
            power.powered = true;
            Destroy(gameObject);


        }
    }
    
}