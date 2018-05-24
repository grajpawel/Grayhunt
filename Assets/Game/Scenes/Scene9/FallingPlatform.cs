using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour {
	public static int collisioncount;
	// Use this for initialization
	void Start () {
		collisioncount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Player")
		collisioncount = 1;
	}
	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.name == "Player")
			collisioncount = 1;
	}
		
	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.name == "Player")
			collisioncount = 0;
	}
}

