using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCol : MonoBehaviour {
	public static int column;
	private int trigname;
	// Use this for initialization
	void Start () {
		column = 0;
		int.TryParse (gameObject.name, out trigname);

	}
	
	// Update is called once per frame

		void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Player") {
			column = trigname;
			Debug.Log (trigname);
		}
	}
				
	
}
