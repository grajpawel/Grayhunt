using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour {
	public static bool hasUnlocked;
	// Use this for initialization
	void Start () {
		hasUnlocked = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward);
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Player") {
			hasUnlocked = true;
			Destroy (this.gameObject);
		}
	}
}
