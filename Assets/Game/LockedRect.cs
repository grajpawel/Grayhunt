using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedRect : MonoBehaviour {
	private int intname;
	// Use this for initialization
	void Start () {
		Color tmp = GetComponent<SpriteRenderer> ().color;
		int.TryParse (transform.parent.name, out intname);

		if (PlayerPrefs.GetInt ("Scene" + (intname - 1).ToString () + "Finish") == 1)
			tmp.a = 0;
		GetComponent<SpriteRenderer> ().color = tmp;
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
