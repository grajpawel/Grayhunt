using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour {
	public float blinkMax;
	public float blinkMin;
	private bool alphaUp = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Color tmp = GetComponent<SpriteRenderer> ().color;
		if (alphaUp == false) 
			tmp.a -= 0.01f;
		
		if (alphaUp == true) 
			tmp.a += 0.01f;
		
		if (tmp.a <= blinkMin)
			alphaUp = true;

		if (tmp.a >= blinkMax)
			alphaUp = false;
		
		GetComponent<SpriteRenderer> ().color = tmp;
	}
}
