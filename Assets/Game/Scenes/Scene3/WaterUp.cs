using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterUp : MonoBehaviour {
	private bool hasTpd;
	public float tpY;
	public float startSpeed;
	public float tpSpeed;
	// Use this for initialization
	void Start () {
		hasTpd = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y >= 19.2f)
			transform.position = new Vector2 (transform.position.x, 19.2f);
		if (CollectibleTeleport.tpWater == true) {
			if (hasTpd == false) {
				transform.position = new Vector2 (transform.position.x, tpY);
				hasTpd = true;
			}
		}
		if (hasTpd == false)
			transform.Translate (Vector2.up / startSpeed);
		if (hasTpd == true)
			transform.Translate (Vector2.up / tpSpeed);
		if (transform.position.y - GameObject.Find ("Player").transform.position.y >= -5.9f)
			BackButton.OnTap ();
	}
}
