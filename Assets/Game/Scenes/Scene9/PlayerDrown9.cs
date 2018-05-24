using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDrown9 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("Player").transform.position.x >= -46.5f && GameObject.Find ("Player").transform.position.y <= 51.2f && GameObject.Find ("Player").transform.position.y >= 50f)
			BackButton.OnTap ();
	}
}
