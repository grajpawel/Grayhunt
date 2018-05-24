using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleCol : MonoBehaviour {
	public string rotate;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (rotate == "left")
			transform.Rotate (Vector3.back);
		if (rotate == "right")
			transform.Rotate (Vector3.forward);
	}
	void OnTriggerEnter2D(Collider2D col){
		
			if (col.gameObject.name == "Player")
				BackButton.OnTap ();
		
		
	}
}
