using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaGenerator : MonoBehaviour {
    public List<GameObject> plataformas;
    public float intervalo;
    public float x = 25;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

    private void FixedUpdate()
    {
        if(x <= 330)
        {
            intervalo += Time.deltaTime;
            if (intervalo >= 1)
            {
                int index = Random.Range(0, 4);
                intervalo = 0;
                this.x += 4;
                float y = Random.Range(-4, 3);
                if(index == 3)
                {
                    Instantiate(plataformas[index -3], new Vector3(this.x, y -1, 0), Quaternion.identity);
                    this.x +=1;
                    Instantiate(plataformas[index], new Vector3(this.x, y, 0), Quaternion.identity);
                    this.x += 1;
                    Instantiate(plataformas[index-2], new Vector3(this.x, y -1, 0), Quaternion.identity);
                }
                else
                {
                    Instantiate(plataformas[index], new Vector3(this.x, y, 0), Quaternion.identity);
                }
            }

        }
    }


}
