using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectFollow : MonoBehaviour {
	public string follow;
	public float divideScale = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (GameObject.Find (follow).transform.position.x, GameObject.Find (follow).transform.position.y);
		transform.localScale = new Vector2 (GameObject.Find (follow).transform.localScale.x / divideScale, GameObject.Find (follow).transform.localScale.y / divideScale);
	}
}
