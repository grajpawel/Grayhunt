using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class UpDownEnemy : MonoBehaviour {
	public float UpMax;
	public float DownMax;
	private bool UpMove = true;
	private Rigidbody2D rb;
	public Vector2 velocity;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();


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
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Player")
			BackButton.OnTap ();
		
			
	}
	
}



