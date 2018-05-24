using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement15 : MonoBehaviour {
	private Rigidbody2D rb;
	private int soundId;
	private float moveSpeed = 10;
	private Vector2 vel;
	private float AxZ;
	private int jumpSound;
	private Collider2D coll;
	private bool hasLanded = true;
	private string jumpName;
	private string colName;
	private bool hasJumped = false;
	private int colCount = 0;
	public Color greenColor;
	public Color redColor;
	private float ExitDist;
	private float EnterDist;
	private int wrongSound;
	private int rightSound;
	private float timer;
	// Use this for initialization
	void Start () {
		wrongSound = AudioCenter.loadSound ("wrong");
		rightSound = AudioCenter.loadSound ("right2");
		jumpSound = AudioCenter.loadSound ("jump3");
		rb = GetComponent<Rigidbody2D> ();
		coll = GetComponent<PolygonCollider2D> ();

		rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
		rb.interpolation = RigidbodyInterpolation2D.Extrapolate;

	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (transform.position.y <= -71)
			BackButton.OnTap ();
		//Debug.Log ("col " + colName);
		//Debug.Log ("jump " + jumpName);

		if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
			PlayerPrefs.SetString ("InputMode", "controller");
		if (Input.touchCount > 0)
			PlayerPrefs.SetString ("InputMode", "phone");
		if (PlayerPrefs.GetString ("InputMode") == "phone") {

			AxZ = Input.acceleration.x / 2;
			if (Input.acceleration.x != 0)
				coll.sharedMaterial.friction = 0;
			if (Input.acceleration.x <= 0.2f && Input.acceleration.x >= -0.2f)
				AxZ = 0;
			if (AxZ >= 0.7f)
				AxZ = 0.7f;
			if (AxZ <= -0.7f)
				AxZ = -0.7f;
			rb.AddForce (Vector2.right * 65 * AxZ);

		}
		vel = rb.velocity;
		if (vel.x >= 6)
			vel.x = 6;

		if (vel.x <= -6)
			vel.x = -6;
		rb.velocity = vel;
		if (PlayerPrefs.GetString ("InputMode") == "controller") {
			if (Input.GetAxis("Horizontal") > 0){
				coll.sharedMaterial.friction = 0.15f;
				rb.AddForce (Vector2.right * moveSpeed);
			}
			if (Input.GetAxis("Horizontal") < 0){
				rb.AddForce (Vector2.right * -moveSpeed);
				coll.sharedMaterial.friction = 0.15f;
			}
		}
		if (rb.velocity.y < 0)
			hasLanded = false;
		if (rb.velocity.y == 0) {
			if (hasLanded == false) {
				
				hasLanded = true;
			}
		}

		//transform.Translate (Input.GetAxis ("Horizontal") / 10, 0, 0, Space.World);
		//transform.Translate (new Vector3 (AxZ, 0, 0), Space.World)

		if (colName == "RightFloor" || colName == "LeftFloor") {
			if (colName != jumpName) {
				if (PlayerPrefs.GetString ("InputMode") == "controller") {
					if (Input.GetButtonDown ("Jump") || Input.GetButtonDown ("Submit"))
						Jump ();
				}
				if (PlayerPrefs.GetString ("InputMode") == "phone") {
					for (int i = 0; i < Input.touchCount; ++i) {
						if (Input.GetTouch (i).phase == TouchPhase.Began)
							Jump ();


					}
				}
			}
		}
		if (colName != "RightFloor" && colName != "LeftFloor") {
			if (rb.velocity.y == 0 || UpDownPlatform.collisioncount == 1 || FallingPlatform.collisioncount == 1) {
				if (PlayerPrefs.GetString ("InputMode") == "controller") {
					if (Input.GetButtonDown ("Jump") || Input.GetButtonDown ("Submit"))
						Jump ();
				}
				if (PlayerPrefs.GetString ("InputMode") == "phone") {
					for (int i = 0; i < Input.touchCount; ++i) {
						if (Input.GetTouch (i).phase == TouchPhase.Began)
							Jump ();
					}

				}
			}
		}
	}	

	void Jump() {
		if (PlayerPrefs.GetInt ("Sound") == 1)
			AudioCenter.playSound (jumpSound);
		hasLanded = false;
		rb.AddForce (Vector2.up * 400);

		hasJumped = true;

	}
	void OnCollisionEnter2D(Collision2D col){
		EnterDist = Vector2.Distance (transform.position, GameObject.Find ("Exit").transform.position);
		if (EnterDist < ExitDist) {
			if (PlayerPrefs.GetInt ("Sound") == 1)
				AudioCenter.playSound (rightSound);
			col.gameObject.GetComponent<SpriteRenderer> ().color = greenColor;
		} else {
			if (timer >= 1) {
				if (PlayerPrefs.GetInt ("Sound") == 1)
					AudioCenter.playSound (wrongSound);
				col.gameObject.GetComponent<SpriteRenderer> ().color = redColor;
			}
		}
		colCount++;

		hasJumped = false;
		colName = col.gameObject.name;


	}



	void OnCollisionExit2D(Collision2D col){
		ExitDist = Vector2.Distance (col.transform.position, GameObject.Find ("Exit").transform.position);
		colCount--;
		jumpName = col.gameObject.name;


	}

	void OnCollisionStay2D(Collision2D col){
		colName = col.gameObject.name;
		if (hasJumped == true) {			
			jumpName = col.gameObject.name;


		}
	}
}

