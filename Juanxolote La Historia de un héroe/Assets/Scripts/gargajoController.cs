using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gargajoController : MonoBehaviour {
    public GameObject gargajo;
    public gargajoController sharedInstance;
    void Awake()
    {
        this.sharedInstance = this;
    }

    public void generar()
    {
        Instantiate(gargajo, new Vector3(MarioController.sherdInstance.rb2d.position.x+0.3f, MarioController.sherdInstance.rb2d.position.y, 0), Quaternion.identity);
    }
}
