using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (GameObject.Find ("Player").transform.position.x, GameObject.Find ("Player").transform.position.y);
		transform.localScale = new Vector2 (GameObject.Find ("Player").transform.localScale.x, GameObject.Find ("Player").transform.localScale.y);
	}
}
