using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBG8 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().enabled = true;

	}
	
	// Update is called once per frame
	void Update () {
		Color tmp = GetComponent<SpriteRenderer> ().color;
		tmp.a = RocketPlatform.color * 0.015f;
		GetComponent<SpriteRenderer> ().color = tmp;
	}
}
