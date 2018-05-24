using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ss : MonoBehaviour {
	private static ss instance = null;
	public static  ss Instance {
		get { return instance; }
	}
	// Use this for initialization
	void Awake(){
		if (instance != null && instance != this) {
			Destroy (this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad (this.gameObject);
	}
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString("lastscene", "0");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
