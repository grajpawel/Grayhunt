using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpSound : MonoBehaviour {
	private int jumpSound;
	private int longjumpSound;

	public Color Color1;
	public Color Color2;
	public Color Color3;
	public Color Color4;
	public Color Color5;
	// Use this for initialization
	void Start () {
		jumpSound = AudioCenter.loadSound ("jump3");
		longjumpSound = AudioCenter.loadSound ("longjump");
	}
	
	// Update is called once per frame
	void Update () {
		if (RocketPlatform.color == 1)
			GetComponent<SpriteRenderer> ().color = Color1;
		if (RocketPlatform.color == 2)
			GetComponent<SpriteRenderer> ().color = Color2;
		if (RocketPlatform.color == 3)
			GetComponent<SpriteRenderer> ().color = Color3;
		if (RocketPlatform.color == 4)
			GetComponent<SpriteRenderer> ().color = Color4;
		if (RocketPlatform.color == 5)
			GetComponent<SpriteRenderer> ().color = Color5;
	}
	void OnCollisionEnter2D(Collision2D col){
		if (PlayerPrefs.GetInt ("Sound") == 1) {
			if (col.gameObject.tag == "pinball")
				AudioCenter.playSound (longjumpSound);
			else
				AudioCenter.playSound (jumpSound);
		}
	}
		
}
