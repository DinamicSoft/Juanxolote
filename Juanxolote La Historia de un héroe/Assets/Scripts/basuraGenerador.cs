using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basuraGenerador : MonoBehaviour {
    public List<GameObject> basuras;
    public float intervalo = 0;
    float x = 25;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        intervalo += Time.deltaTime;
        if (intervalo >= 4)
        {
            int indice = Random.Range(0, 6);
            Instantiate(basuras[indice], new Vector3(this.gameObject.transform.position.x+x, 5, 0), Quaternion.identity);
            x += 8;
            intervalo = 0;
        }
    }
}
