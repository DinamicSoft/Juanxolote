using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	
	public float parallaxSpeed = 0.02f;
	public RawImage fondo;
	public RawImage suelo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	float finalSpeed = parallaxSpeed * Time.deltaTime;
	fondo.uvRect = new Rect(fondo.uvRect.x + finalSpeed,0f,1f,1f);
	suelo.uvRect = new Rect(suelo.uvRect.x + finalSpeed *4 ,0f,1f,1f);
		
	}
}
