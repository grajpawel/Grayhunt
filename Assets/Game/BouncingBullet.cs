using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBullet : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
			transform.Rotate (Vector3.forward * 4.5f);
			transform.Translate (Vector2.right / 4);
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Player")			
			BackButton.OnTap ();
		
	}
}