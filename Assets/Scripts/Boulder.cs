using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    public Transform StartPosition;
    public AudioSource impact;
    void Start()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ground")
        {
            impact.Play();
            transform.position =  StartPosition.position;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
