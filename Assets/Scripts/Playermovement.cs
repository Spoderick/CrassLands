using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    GameManager vidas;
    public Transform respawnpoint;
    public GameObject fallDetector;
    GunScript ammo;
    GunScript falls;


    //Aduio
    public AudioSource DamageS;
    void Start()
    {
        vidas =  FindObjectOfType<GameManager>(); 
        ammo =  FindObjectOfType<GunScript>(); 
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            
        }
        fallDetector.transform.position = new Vector2(transform.position.x, fallDetector.transform.position.y);

    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);

        jump = false;
    }

    void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Killer")
        {
            transform.position = respawnpoint.position;
            Damage();
        }
        else if (collision.tag == "CheckPoint")
        {
            respawnpoint.position = transform.position;
        }

    }
    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "Killer")
        {
            transform.position = respawnpoint.position;
            Damage();
        }
        else if (col.gameObject.tag == "CheckPoint")
        {
            respawnpoint.position = transform.position;
        }

    }

    void Damage()
    {
        vidas.Lives = vidas.Lives - 1f;
        ammo.Magazine = ammo.Magazine + 1f;
        MainMenu.Tloses += 1f;
        DamageS.Play();


    }
}
