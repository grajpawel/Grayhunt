using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour {
	public Sprite on;
	public Sprite off;
	private Button button;



	// Use this for initialization
	void Start () {
		button = GetComponent<Button> ();

		if (PlayerPrefs.HasKey ("Sound")) {
		}
		else {
			PlayerPrefs.SetInt("Sound", 1);

		}

	}
	void Update(){
		if (FrontSwipe.scene == -2) {
			if (Input.GetButtonDown ("Submit")) {
				OnTap ();
			}
		}

		if (PlayerPrefs.GetInt ("Sound") == 1) {
			button.image.sprite = on;
			AudioListener.volume = 1;
		} else {
			button.image.sprite = off;
			AudioListener.volume = 0;
		}
	}

	 public void OnTap(){


		if (PlayerPrefs.GetInt ("Sound") == 1)
			PlayerPrefs.SetInt ("Sound", 0);
		else	
			
			PlayerPrefs.SetInt("Sound", 1);
	}
}

