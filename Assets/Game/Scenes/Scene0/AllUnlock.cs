using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllUnlock : MonoBehaviour {
	private bool unlock;
	// Use this for initialization
	void Awake () {
		unlock = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (unlock == true) {
			for (int i = 0; i < 16; i++)
				PlayerPrefs.SetInt (("Scene" + i.ToString () + "Finish"), 1);
		}
	}
	public void OnTap(){
		unlock = true;
	}
}
