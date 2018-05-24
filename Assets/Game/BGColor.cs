using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGColor : MonoBehaviour {
	public Color blue;
	public Color red;
	public Color white;
	// Use this for initialization
	void Start () {
		if (CameraMove.scene == "1" || CameraMove.scene == "6" || CameraMove.scene == "11" || CameraMove.scene == "5" || CameraMove.scene == "10" || CameraMove.scene == "15")
			gameObject.GetComponent<Renderer> ().material.color = white;
		if (CameraMove.scene == "2" || CameraMove.scene == "7" || CameraMove.scene == "12" || CameraMove.scene == "4" || CameraMove.scene == "9" || CameraMove.scene == "14")
			gameObject.GetComponent<Renderer> ().material.color = blue;
		if (CameraMove.scene == "3" || CameraMove.scene == "8" || CameraMove.scene == "13")
			gameObject.GetComponent<Renderer> ().material.color = red;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
