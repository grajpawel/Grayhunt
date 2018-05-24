using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("escape") || Input.GetButton("Cancel"))
			OnTapButton ();
	}
	public static void OnTap(){
		CameraMove.scene = "0";
	}
	public void OnTapButton(){
		CameraMove.scene = "0";
	}
}
