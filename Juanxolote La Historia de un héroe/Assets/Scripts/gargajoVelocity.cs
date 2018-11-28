using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gargajoVelocity : MonoBehaviour {
    private Rigidbody2D rb2d;
    // Use this for initialization
    private void Awake()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
    }
    void Start () {
        this.rb2d.AddForce(new Vector2(35f, 0));
    }
	
	// Update is called once per frame
	void Update () {
        this.rb2d.AddForce(new Vector2(15f, 0));
    }
}
