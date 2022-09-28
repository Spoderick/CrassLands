using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public float Lives;
    public Text ammoText;
    public Text LivesT;
    GunScript ammo;
    public GameObject PauseLayout;
    private bool paused;
    public GameObject GunScript;
    public GameObject Character;
    public AudioSource pauseS;
    public AudioSource unpauseS;
    public string CurrentScene;
    
    


    void Start()
    {
        //Cursor.visible = false;
        ammo =  FindObjectOfType<GunScript>(); 
        LivesT.text =  "x"+ Lives;
        PauseLayout.SetActive(false);
        paused = false;
        Time.timeScale=1;
        GunScript.gameObject.GetComponent<GunScript>();
        Character.gameObject.GetComponent<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ammoText.text = " "+ ammo.Magazine;
        LivesT.text =  "x"+ Lives;
        if (Input.GetKeyDown(KeyCode.Escape) && paused == false)
        {
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && paused == true)
        {
            Resume();
        }
        else if (Lives<0)
        {
            SceneManager.LoadScene("MainMenu");
        }

        
    }


    void Pause()
    {
        Time.timeScale=0;
        PauseLayout.SetActive(true);
        paused = true;
        GunScript.SetActive(false);
        Character.SetActive(false);
        pauseS.Play();
    }
    void Resume()
    {
        Time.timeScale=1;
        PauseLayout.SetActive(false);
        paused = false;
        GunScript.SetActive(true);
        Character.SetActive(true);
        unpauseS.Play();
    }

    public void Reload()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
