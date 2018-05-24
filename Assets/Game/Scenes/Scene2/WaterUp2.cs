using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class WaterUp2 : MonoBehaviour {
	private bool hasTpd;
	public float tpSpeed;
	public Vector2 tpPos;
	// Use this for initialization
	void Start () {
		hasTpd = false;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y >= 0f)
			transform.position = new Vector2 (transform.position.x, 0f);
		if (WaterFloor.tpWater == true){
			if (hasTpd == false) {
				transform.DOMove (tpPos, 1);
				hasTpd = true;
			}
		}

		if (hasTpd == true)
			transform.Translate (Vector2.up / tpSpeed);
		if (transform.position.y - GameObject.Find ("Player").transform.position.y >= -5.9f)
			BackButton.OnTap ();
	}

}
