using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class swipeText : MonoBehaviour {
	private bool up;
	private float speed = 0.005f;
	// Use this for initialization
	void Start () {
		up = true;
		//PlayerPrefs.DeleteAll ();
		if (PlayerPrefs.HasKey("HasSwiped")){
		}
		else
		PlayerPrefs.SetInt("HasSwiped", 0);
		if (PlayerPrefs.GetInt ("HasSwiped") == 1)
			Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		Color tmp = GetComponent<Text> ().color;
		if (PlayerPrefs.GetInt ("HasSwiped") == 1)
			tmp.a -= speed;
		else {
			if (up == true) {
				tmp.a += speed;
				if (tmp.a >= 0.9f)
					up = false;
			} else {
				tmp.a -= speed;
				if (tmp.a <= 0.2f)
					up = true;
			}
		}
	
		

	
		GetComponent<Text> ().color = tmp;
		

	}
}
