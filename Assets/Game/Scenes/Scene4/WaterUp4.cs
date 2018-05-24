using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterUp4 : MonoBehaviour {
	public float waterDistance;
	public float waterLevel;
	public float risingSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (WaterFloor.tpWater == true) {
			if (transform.position.y - GameObject.Find ("Player").transform.position.y >= waterDistance)
				BackButton.OnTap ();
			if (transform.position.y <= waterLevel)
				transform.Translate (Vector2.up / risingSpeed);
		
		}
	}
}
