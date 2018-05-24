using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit15 : MonoBehaviour {
	public float[] startX;
	public float[] startY;
	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (startX [Random.Range (0, startX.Length)], startY [Random.Range (0, startY.Length)]);
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward);

	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Player") {
			PlayerPrefs.SetInt (SceneManager.GetActiveScene ().name.ToString () + "Finish", 1);
			BackButton.OnTap ();
		}
	}
}
