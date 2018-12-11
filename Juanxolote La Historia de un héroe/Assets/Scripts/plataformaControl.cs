using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaControl : MonoBehaviour {

    public Animator anim { get; set; }
    public AudioSource audioS;
    private void Awake()
    {
        audioS = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag != "ground")
        {
            audioS.Play();
            anim.Play("plataformaCollision");
        }
        
    }
}
