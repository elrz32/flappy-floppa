using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floppa : MonoBehaviour
{
    Rigidbody2D floppa_body;    //da fare sempre quando si vuole lavorare con un oggetto
    public GameObject gameover;
    public GameObject sogga;
    public GameObject jesahel;
    public GameObject anni;
    public GameObject restart_button;
    public AudioClip[] audioClips;
    AudioSource audioSource;
    void Start()
    {
        floppa_body = GetComponent<Rigidbody2D>();  //da fare sempre quando si vuole lavorare con un oggetto
        audioSource = GetComponent<AudioSource>();
    }
       
    void Update()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")) && gamecontroller.game_over!=true)//lo zero sta per il tasto sinistro del mouse
        {
            floppa_body.velocity = new Vector2(0f, 07f);
            audioSource.PlayOneShot(audioClips[0]);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    { 
        audioSource.PlayOneShot(audioClips[1]);
        gamecontroller.game_over = true;
        gameover.SetActive(true);
        sogga.SetActive(true);
        jesahel.SetActive(true);
        anni.SetActive(true);
        restart_button.SetActive(true);
    }
}
