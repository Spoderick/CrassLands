using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    public float Scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            SceneChanger();
            

        }

    }

    void SceneChanger(){
        if (Scene == 1f)
        {
            SceneManager.LoadScene("Tutorial 2");
        }
        else if (Scene == 2f){
            SceneManager.LoadScene("Tutorial 3");
        }
        else if (Scene == 3f){
            SceneManager.LoadScene("MainMenu");
        }
    }


}
