﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioController : MonoBehaviour {
    public Rigidbody2D rb2d;
    public Animator anim;
    private bool IsOnTheFloor;
    public bool derecha;
    public static MarioController sherdInstance;
    

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        derecha = true;
        sherdInstance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        if (IsOnTheFloor)
        {
            if (Input.GetKey("left"))
            {
                if (Input.GetKey("c"))
                {
                    rb2d.AddForce(new Vector2(-220f, 0));
                }
                else
                {
                    rb2d.AddForce(new Vector2(-150f, 0));
                }
                //gameObject.transform.Translate(-10 * Time.deltaTime, 0, 0);
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                anim.Play("Walk");
                derecha = false;
            }
            if (Input.GetKey("right"))
            {
                if (Input.GetKey("c"))
                {
                    rb2d.AddForce(new Vector2(220f, 0));
                }
                else
                {
                    rb2d.AddForce(new Vector2(150f, 0));
                }
                //gameObject.transform.Translate(10 * Time.deltaTime, 0, 0);
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                anim.Play("Walk");
                derecha = true;
            }
            if (Input.GetKeyDown("up"))
            {
                rb2d.AddForce(new Vector2(rb2d.velocity.x * 2 , 5000f));
                //anim.Play("Jump");
                IsOnTheFloor = false;
            }
            if(rb2d.velocity.x == 0 && rb2d.velocity.y == 0)
            {
                anim.Play("Idle");
            }
              
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground")
        {
            IsOnTheFloor = true;
        }
        
    }
}
