using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject Bullet;
    Vector2 direction; 
    public float BulletSpeed;
    public Transform Shootpoint;
    public float bulletLife;
    public float Magazine = 1f;
    public bool powered;
    public GameObject PoweredShot;
    public float BulletSpeedU;
    public GameObject Character;
    public SpriteRenderer GunTip;
    //Audio
    public AudioSource ShootSound;
    public AudioSource NoAmmoSound;
    public AudioSource BulletDestroyS;


    
    void Start()
    {
        powered = false;
        
    }

    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            if (powered)
            {  
                
                ShootPower();
            }
            else
            {
                Shoot();
            }
        }
        else if (powered){
            GunTip.color = Color.red;
        }       
    }


    void Shoot()
    {
        
        if (Magazine>0)
        {
            ShootSound.Play();
            GameObject BulletIns = Instantiate(Bullet, Shootpoint.position, Shootpoint.rotation);
            BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * BulletSpeed);
            Magazine -= 1;
            Destroy(BulletIns, bulletLife);
            BulletDestroyS.Play();
        }
        else{
            NoAmmoSound.Play();
        }
    }

    void ShootPower()
    {
        ShootSound.Play();
        GameObject BulletUIns = Instantiate(PoweredShot, Shootpoint.position, Shootpoint.rotation);
        BulletUIns.GetComponent<Rigidbody2D>().AddForce(BulletUIns.transform.right * BulletSpeedU);
        Magazine -= 1;
        Destroy(BulletUIns, bulletLife);
        BulletDestroyS.Play();
        powered = false;
        GunTip.color = new Color(0, 255, 220);   
    }

}
