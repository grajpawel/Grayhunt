using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleGray3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("s1c3") == 1)
			Destroy (this.gameObject);
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward);
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Player") {
			PlayerPrefs.SetInt ("Score1", PlayerPrefs.GetInt ("Score1") + 1);
			PlayerPrefs.SetInt ("s1c3", 1);
			Debug.Log (PlayerPrefs.GetInt ("Score1"));
			Destroy (this.gameObject);
		}
	}
}
