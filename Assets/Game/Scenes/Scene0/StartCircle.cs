using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCircle : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Color tmp = GetComponent<SpriteRenderer> ().color;
		if (PlayerPrefs.GetString ("lastscene") == "0") {
				tmp.a -= 0.035f;
			if (tmp.a <= 0)
				Destroy (gameObject);
		} else
			Destroy (gameObject);
		
		GetComponent<SpriteRenderer> ().color = tmp;
	}
}
