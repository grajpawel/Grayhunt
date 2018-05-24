using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroingButton : MonoBehaviour {

	public void OnTap(){
		PlayerPrefs.DeleteAll ();
	}
}
