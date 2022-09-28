using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Transform Gun;
    Vector2 direction;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector2 mousePos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)Gun.position;
        FaceMouse();
    }

    void FaceMouse(){

    }
}
