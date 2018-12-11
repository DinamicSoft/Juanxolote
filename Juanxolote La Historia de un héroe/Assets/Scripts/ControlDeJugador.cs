using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeJugador : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public LayerMask lm;
    public Animator anim;
    private bool IsOnTheFloor;
    public bool derecha;
    public static ControlDeJugador sherdInstance;
    public float vida;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        derecha = true;
        this.vida = 100;
        sherdInstance = this;
        ScoreManager.scoreM.actualizarVida(vida);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -15)
        {
            vida = 0;
            ScoreManager.scoreM.actualizarVida(vida);
        }
    }

    private void FixedUpdate()
    {
        if (IsOnTheFloor)
        {
            if (Input.GetKey("left"))
            {
                if (Input.GetKey("c"))
                {
                    rb2d.AddForce(new Vector2(-50f, 0));
                }
                else
                {
                    rb2d.AddForce(new Vector2(-35f, 0));
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
                    rb2d.AddForce(new Vector2(50f, 0));
                }
                else
                {
                    rb2d.AddForce(new Vector2(35f, 0));
                }
                //gameObject.transform.Translate(10 * Time.deltaTime, 0, 0);
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                anim.Play("Walk");
                derecha = true;
            }

            if (Input.GetKeyDown("up"))
            {
                if (rb2d.velocity.y <= 1200)
                {
                    rb2d.AddForce(new Vector2(rb2d.velocity.x / 10, 1200f));
                }
                else
                {
                    rb2d.AddForce(new Vector2(rb2d.velocity.x / 10, 0f));
                }
            }
            if (rb2d.velocity.x == 0 && rb2d.velocity.y == 0)
            {
                anim.Play("Idle");
            }
        }
        else
        {
            anim.Play("Jump");
            if (Input.GetKey("left"))
            {
                if (Input.GetKey("c"))
                {
                    rb2d.AddForce(new Vector2(-30f, 0));
                }
                else
                {
                    rb2d.AddForce(new Vector2(-15f, 0));
                }
                //gameObject.transform.Translate(-10 * Time.deltaTime, 0, 0);
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                //anim.Play("Walk");
                derecha = false;
            }
            if (Input.GetKey("right"))
            {
                if (Input.GetKey("c"))
                {
                    rb2d.AddForce(new Vector2(30f, 0));
                }
                else
                {
                    rb2d.AddForce(new Vector2(15f, 0));
                }
                //gameObject.transform.Translate(10 * Time.deltaTime, 0, 0);
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                //anim.Play("Walk");
                derecha = true;
            }
        }
            
        setIsOnTheFloor();
        levantarse();
    }

    private void setIsOnTheFloor()
    {
        IsOnTheFloor = Physics2D.Raycast(this.transform.position, Vector2.down, 1f, lm.value);
    }

    public void levantarse()
    {
        if (Physics2D.Raycast(this.transform.position, Vector2.left, 1f, lm.value) || Physics2D.Raycast(this.transform.position, Vector2.right, 1f, lm.value))
        {
            rb2d.transform.Rotate(new Vector3(0, 0, 0), 0f);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground")
        {
            IsOnTheFloor = true;
        }
        if (collision.transform.tag == "dañino")
        {
            this.vida -= 30;
            ScoreManager.scoreM.actualizarVida(vida);
        }
        if (collision.transform.tag == "basura")
        {
            this.vida -= 10;
            ScoreManager.scoreM.actualizarVida(vida);
        }
    }
}
