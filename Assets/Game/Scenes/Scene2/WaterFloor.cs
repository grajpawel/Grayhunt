using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFloor : MonoBehaviour {
	public static bool tpWater;
	// Use this for initialization
	void Start () {
		tpWater = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Player") 
			tpWater = true;
		
		
		}
}
