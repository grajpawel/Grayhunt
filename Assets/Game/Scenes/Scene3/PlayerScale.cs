using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PlayerScale : MonoBehaviour {
	public static bool hasUnblocked;
	public Vector2 playerScale;
	public float scaleTime = 1;
	// Use this for initialization
	void Start () {
		hasUnblocked = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward);

	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Player") {
			GameObject.Find ("Player").transform.DOScale (playerScale, scaleTime);
			hasUnblocked = true;
			if (gameObject.name != "noDestroy")
			Destroy (this.gameObject);
		}
	}
}
