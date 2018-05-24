using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player45Rotate : MonoBehaviour {
	public static int collisioncount;
	public static bool hasHit;
	private int landSound;

	// Use this for initialization
	void Start () {
		landSound = AudioCenter.loadSound ("landing");
		hasHit = false;
		collisioncount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Player") {
			if (PlayerPrefs.GetInt ("Sound") == 1)
				AudioCenter.playSound (landSound);
			collisioncount = 1;
			hasHit = true;
		}
		
	}
	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.name == "Player")
		collisioncount = 0;
		
	}
}
