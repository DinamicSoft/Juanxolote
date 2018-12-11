using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parallax : MonoBehaviour {
	
	public float parallaxSpeed = 0.02f;
	public RawImage fondo;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	float finalSpeed = parallaxSpeed * Time.deltaTime;
	fondo.uvRect = new Rect(fondo.uvRect.x + finalSpeed,0f,1f,1f);
	
		
	}
}
