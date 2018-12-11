using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlechaControler : MonoBehaviour {
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag != "ground")
        {
            anim.Play("flechaCollision");
        }
    }
}
