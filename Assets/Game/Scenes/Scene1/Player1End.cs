using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1End : MonoBehaviour {
	public float dis;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("Player").transform.position.y <= dis)
			BackButton.OnTap ();
	}
}
