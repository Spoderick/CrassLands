using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonballShooter : MonoBehaviour
{
    public GameObject Bullet;
    Vector2 direction; 
    public float BulletSpeed;
    public Transform Shootpoint;
    public float ballLife;
    public float Firetime;
    float infinito=1f;
    public GameObject Muzzle;


    public AudioSource ShootSound;
    
    
   
    void Start()
    {
        StartCoroutine("shootcanon");
    }

    IEnumerator shootcanon()
    {
        while (infinito < 2f)
        {
            
            Debug.Log("Dispare!!!!");
            ShootSound.Play();
            GameObject BulletIns = Instantiate(Bullet, Shootpoint.position, Shootpoint.rotation);
            GameObject MuzzeIns = Instantiate(Muzzle, Shootpoint.position, Shootpoint.rotation);
            BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * BulletSpeed);
            Debug.Log("chingo!!!!");
            Destroy(BulletIns, ballLife);
            yield return new WaitForSeconds(Firetime);
            

        }  
    }

    void Update()
    {
        
    }
}
