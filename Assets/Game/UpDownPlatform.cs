using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class UpDownPlatform : MonoBehaviour {
	public float UpMax;
	public float DownMax;
	private bool UpMove = true;
	private Rigidbody2D rb;
	public Vector2 velocity;
	public static int collisioncount;
	public static bool hasHit;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		hasHit = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (UpMove == true) {
			if (transform.position.y <= UpMax)
				rb.MovePosition (rb.position + velocity * Time.fixedDeltaTime);
			else
				UpMove = false;
		}
	
	if (UpMove == false) {
		if (transform.position.y >= DownMax)
			rb.MovePosition (rb.position + -velocity * Time.fixedDeltaTime);
			else 
				UpMove = true;
		}
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Player")
			hasHit = true;
		collisioncount = 1;
		Debug.Log ("Enter");
	}
	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.name == "Player")
			hasHit = false;
		collisioncount = 0;
		Debug.Log ("Exit");
	}
}
		
		
			
