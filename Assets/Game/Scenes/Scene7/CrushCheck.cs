using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrushCheck : MonoBehaviour {
	private bool hasHit;
	public float border;
	// Use this for initialization
	void Start () {
		hasHit = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("MovingFloor").transform.position.y >= border) {
			if (hasHit == true && UpDownPlatform.hasHit == true)
				BackButton.OnTap ();
		}
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Player")
			hasHit = true;
	}
	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.name == "Player")
			hasHit = false;
	}

			
}
