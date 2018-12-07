using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gargajoVelocity : MonoBehaviour {
    private Rigidbody2D rb2d;
    float incremento = 0.3f;
    string direccion; 
    // Use this for initialization
    private void Awake()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
    }
    void Start () {
        Destroy(this.gameObject, 8f);
        if (MarioController.sherdInstance.derecha)
        {
            direccion = "derecha";
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + 1.5f, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        }
        else
        {
            direccion = "izquierda";
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x - 1.5f, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        //this.rb2d.AddForce(new Vector2(30f, 3f));
    }
	
	// Update is called once per frame
	void Update () {

        if (direccion == "derecha")
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + 0.15f, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        }
        else
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x - 0.15f, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.otherCollider.tag != "ground")
        {
            Destroy(this.gameObject );
        }*/
    }
}
