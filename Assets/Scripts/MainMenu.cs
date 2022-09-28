using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject Rocket;
    public Animator m_Animator;
    public AudioSource fallig;
    public Text deaths;
    public static float Tloses;
    public AudioSource haha;
    public AudioSource hahaha;

    public Text dialogues;
    


    void Start()
    {
        Time.timeScale=1;
        dialogues.text="";
        m_Animator =  Rocket.GetComponent<Animator>();
        deaths.text = "Total deaths: " + Tloses;
        if (Tloses > 4 && Tloses < 10)
        {
            haha.Play();
            dialogues.text = "I cant believe you died so much, its not that hard ";
            StartCoroutine("sial");
        }
        else if (Tloses > 10)
        {
            hahaha.Play();
            dialogues.text = "More deaths?, if you quit the game, the counter resents. Erick didnt had time to program data saving. ";
            StartCoroutine("sial");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        m_Animator.SetTrigger("Fall");
        fallig.Play();
        dialogues.text="Falling";
        StartCoroutine(Starting());
        
    }


    IEnumerator Starting()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Tutorial 1");

    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial 4");
    }
    public void Quitg()
    {
        Application.Quit();
    }

    IEnumerator sial()
    {
        yield return new WaitForSeconds(6);
        dialogues.text = "";
    }
    


}




