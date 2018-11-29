using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gargajoController : MonoBehaviour {
    public GameObject gargajo;
    void Awake()
    {

    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown("v"))
        {
            generar();
        }
    }

    public void generar()
    {
        Instantiate(gargajo, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z), Quaternion.identity);
    }
}
