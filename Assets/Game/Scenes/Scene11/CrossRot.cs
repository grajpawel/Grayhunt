using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossRot : MonoBehaviour {
	public string rotate;
	public float rotSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (rotate == "left")
			transform.Rotate (Vector3.back * rotSpeed);
		if (rotate == "right")
			transform.Rotate (Vector3.forward * rotSpeed);
	}
}
