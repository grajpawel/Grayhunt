
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frameWheelColor : MonoBehaviour {
	public Color black;
	public Color highlight;

	private int nameInt;
	// Use this for initialization
	void Start () {
		int.TryParse (transform.parent.name, out nameInt);

	}
	
	// Update is called once per frame
	void Update () {
		
		if (PlayerPrefs.GetString ("InputMode") == "controller") {
			if (FrontSwipe.scene == nameInt) {
				GetComponent<SpriteRenderer> ().color = highlight;
				if (Input.GetButtonDown ("Submit")) {
					if (nameInt != 1) {
						if (PlayerPrefs.GetInt ("Scene" + (nameInt - 1).ToString () + "Finish") == 1)
							CameraMove.scene = transform.parent.name;
					}
					else
						CameraMove.scene = transform.parent.name;
				}
			}	else
				GetComponent<SpriteRenderer> ().color = black;
		} else
			GetComponent<SpriteRenderer> ().color = black;
	}
}
