using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSound : MonoBehaviour
{
    public AudioSource ColSound;
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        ColSound.Play();
    }
}
