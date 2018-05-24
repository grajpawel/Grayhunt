using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RightLeftPlatform : MonoBehaviour {

		public float LeftMax;
		public float RightMax;
		private bool RightMove = true;
		private Rigidbody2D rb;
		public Vector2 velocity;
		public static int collisioncount;
		// Use this for initialization
		void Start () {
			rb = GetComponent<Rigidbody2D> ();


		}

		// Update is called once per frame
		void Update () {
		
			if (RightMove == true) {
				if (transform.position.x <= RightMax)
				rb.MovePosition (rb.position + velocity * Time.fixedDeltaTime);
				else
				RightMove = false;
			}

		if (RightMove == false) {
			if (transform.position.x >= LeftMax)
				rb.MovePosition (rb.position + -velocity * Time.fixedDeltaTime);
				else 
				RightMove = true;
			}
		}
		void OnCollisionEnter2D(){
			collisioncount++;
		}
		void OnCollisionExit2D(){
			collisioncount--;
		}
	}



