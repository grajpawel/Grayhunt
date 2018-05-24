using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFrame : MonoBehaviour {
	public Color invisible;
	public Color highlight;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetString ("InputMode") == "controller") {

			if (FrontSwipe.scene == 0)
				GetComponent<SpriteRenderer> ().color = highlight;
			else
				GetComponent<SpriteRenderer> ().color = invisible;
		} else
			GetComponent<SpriteRenderer> ().color = invisible;
	}
}
