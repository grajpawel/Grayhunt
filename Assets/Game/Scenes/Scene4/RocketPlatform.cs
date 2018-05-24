using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RocketPlatform : MonoBehaviour {
	private Rigidbody2D playerRb;
	private int jumpSound;
	public int force = 1000;
	public string direction = "up";
	public static int color;
	public static int platformcolor;
	public Color color1;
	public Color color2;
	public Color color3;
	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().color = color1;
		color = 0;
		platformcolor = 0;
			jumpSound = AudioCenter.loadSound ("jump3");

		playerRb = GameObject.Find("Player").GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().name == "Scene8") {			
			if (platformcolor == 1)
				GetComponent<SpriteRenderer> ().color = color1;
			if (platformcolor == 2)
				GetComponent<SpriteRenderer> ().color = color2;
			if (platformcolor == 3)
				GetComponent<SpriteRenderer> ().color = color3;
		}
		
	
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Player") {
			if (SceneManager.GetActiveScene ().name == "Scene8") {
				
				platformcolor++;
				if (platformcolor > 3)
					platformcolor = 1;
				color++;
				Debug.Log (color);
			}
			if (PlayerPrefs.GetInt ("Sound") == 1) {				
				if (SceneManager.GetActiveScene ().name != "Scene8")
					AudioCenter.playSound (jumpSound);
			}
			if (direction == "left")
				playerRb.AddForce (Vector2.left * force);
			if (direction == "right")
				playerRb.AddForce (Vector2.right * force);
			if (direction == "up")
				playerRb.AddForce (Vector2.up * force);
			if (direction == "down")
				playerRb.AddForce (Vector2.down * force);
			
		}
	}
}
