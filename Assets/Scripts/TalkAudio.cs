using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkAudio : MonoBehaviour
{
    public AudioSource TalkBackAudio;
    private bool Played;
    public Text dialogue;
    public string dia = "Well done, Its going to get a lot harder";
    public float waittime;
    public GameObject Barrier;

    void Start(){
        Played = false;
        dialogue.text = "";
    }

    public void OnTriggerEnter2D(Collider2D col){
        if (Played == false && col.gameObject.tag == "Player")
        {
            Played = true;
            dialogue.text = dia;
            TalkBackAudio.Play();
            StartCoroutine("delete");

        }
        else if (col.gameObject.tag == "Boxes")
        {
            Destroy(col.gameObject);
        }
    }
    
    IEnumerator delete(){
        yield return new WaitForSeconds(waittime);
        dialogue.text = "";
        Barrier.SetActive(false);

    }
    
}
