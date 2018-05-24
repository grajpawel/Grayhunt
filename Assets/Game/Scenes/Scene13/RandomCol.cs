using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCol : MonoBehaviour {
	public float[] posX;
	public float posY;
	private int i;
	private bool hasTpd;
	// Use this for initialization
	void Start () {
		hasTpd = false;
		transform.position = new Vector2 (posX [Random.Range (0, posX.Length)], posY);
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name == "Col3") {
			if (TriggerCol.column != 0) {
				if (hasTpd == false){
					int i = Random.Range (1, posX.Length+1);
					Debug.Log (i);
					if (i != TriggerCol.column-1) {
						transform.position = new Vector2 (posX [i], posY);
						hasTpd = true;
					}
				
				}
			}
		}
	}
}
