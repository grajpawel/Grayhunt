using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputButton : MonoBehaviour {
	public Sprite controller;
	public Sprite phone;
	private Button button;

	// Use this for initialization
	void Start () {
		button = GetComponent<Button> ();
		if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.LinuxPlayer) {
			PlayerPrefs.SetString ("InputMode", "controller");
			button.image.sprite = controller;
		}
		if (PlayerPrefs.HasKey ("InputMode")) {
		} else {
			PlayerPrefs.SetString ("InputMode", "phone");

			}
		}

	// Update is called once per frame
	void Update () {
		if (FrontSwipe.scene == 0) {
			if (Input.GetButtonDown ("Submit")) {
				OnTap ();
			}
		}
		if (Input.touchCount > 0)
			PlayerPrefs.SetString ("InputMode", "phone");
		
		if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
			PlayerPrefs.SetString ("InputMode", "controller");
		
		if (PlayerPrefs.GetString ("InputMode") == "phone")
			button.image.sprite = phone;
		else
			button.image.sprite = controller;
		
	}
	public void OnTap(){

		if (PlayerPrefs.GetString ("InputMode") == "phone") 
			PlayerPrefs.SetString ("InputMode", "controller");
		
		else
				PlayerPrefs.SetString ("InputMode", "phone");
				
			

	}
}
