using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Col1Show : MonoBehaviour {
	public Vector2 tpPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Color tmp = GetComponent<SpriteRenderer> ().color;
		if (Player45Rotate.hasHit == true){
			transform.position = tpPos;
			tmp.a += 0.01f;
		}
		GetComponent<SpriteRenderer> ().color = tmp;
	}
}
