using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basuraControler : MonoBehaviour {
    public LayerMask lm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.transform.position.y < -20)
        {
            Destroy(this.gameObject);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "gargajo")
        {
            ScoreManager.scoreM.marcarPuntos(1);
            Destroy(this.gameObject);
        }
    }
}
