using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {
	private Rigidbody2D rb;

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody2D> ();

		rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
		rb.interpolation = RigidbodyInterpolation2D.Extrapolate;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
