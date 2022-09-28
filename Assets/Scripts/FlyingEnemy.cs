using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    public float speed;
    public GameObject Player;
    public bool chase = false;
    public Transform startingpoint;


    private void Start()
    {
        Player =  GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (Player == null)
            return;
        if(chase == true)
            Chase();
        else 
            ReturntoStartPoint();
            
        Flip();        
    }

    // Update is called once per frame
    private void Chase()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed*Time.deltaTime);
    }

    private void  ReturntoStartPoint()
    {
        transform.position =  Vector2.MoveTowards(transform.position, startingpoint.position, speed * Time.deltaTime);
    }

    private void Flip()
    {
        if (transform.position.x>Player.transform.position.x)
            transform.rotation = Quaternion.Euler(0,0,0);
        else
            transform.rotation = Quaternion.Euler(0,-180,0);
    }
}
