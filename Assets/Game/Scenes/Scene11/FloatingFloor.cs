using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class FloatingFloor : MonoBehaviour {
	public float time = 2;
	public Vector3[] Vectors;
	private Rigidbody2D rb;
	public Vector2 velocityVer;
	public Vector2 velocityHor;
	public string direction;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		//if (gameObject.name == "MovingFloor1") {			

	if (direction == "up"){
			rb.MovePosition (rb.position + velocityVer * Time.fixedDeltaTime);
			if (transform.position.y >= Vectors [2].y)
				direction = "right";

	}
		if (direction == "down"){
			rb.MovePosition (rb.position + -velocityVer * Time.fixedDeltaTime);
			if (transform.position.y <= Vectors [5].y)
				direction = "left";
		}
		if (direction == "left"){
			rb.MovePosition (rb.position + -velocityHor * Time.fixedDeltaTime);
			if (transform.position.x <= Vectors [1].x)
				direction = "up";
		}
		if (direction == "right"){
			rb.MovePosition (rb.position + velocityHor * Time.fixedDeltaTime);
			if (transform.position.x >= Vectors [3].x)
				direction = "down";

		}
	}
}
