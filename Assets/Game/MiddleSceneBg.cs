using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MiddleSceneBg : MonoBehaviour {
	public Color blue;
	public Color red;
	public Color white;
	private bool hasScaled;
	private int soundId;
	// Use this for initialization
	void Start () {
		soundId = AudioCenter.loadSound ("woosh2");

	}
	
	// Update is called once per frame
	void Update () {
		if (AudioListener.volume >= 1)
			AudioListener.volume = 1;
		if (AudioListener.volume <= 0)
			AudioListener.volume = 0;
		if (PlayerPrefs.GetString("lastscene") == "7" || PlayerPrefs.GetString("lastscene") == "9" || PlayerPrefs.GetString("lastscene") == "2" || PlayerPrefs.GetString("lastscene") == "4" || PlayerPrefs.GetString("lastscene") == "12" || PlayerPrefs.GetString("lastscene") == "14")
			gameObject.GetComponent<Renderer> ().material.color = blue;
		if (PlayerPrefs.GetString("lastscene") == "1" || PlayerPrefs.GetString("lastscene") == "5" || PlayerPrefs.GetString("lastscene") == "6" || PlayerPrefs.GetString("lastscene") == "10" || PlayerPrefs.GetString("lastscene") == "11" || PlayerPrefs.GetString("lastscene") == "15")
			gameObject.GetComponent<Renderer> ().material.color = white;
		if (PlayerPrefs.GetString("lastscene") == "8" || PlayerPrefs.GetString("lastscene") == "3" || PlayerPrefs.GetString("lastscene") == "13")
			gameObject.GetComponent<Renderer> ().material.color = red;
	

		if (PlayerPrefs.GetString("lastscene") == "0"){
			if (CameraMove.scene != "0") {
				if (gameObject.name == "MiddleScene" && PlayerPrefs.GetInt ("Sound") == 1)
					AudioListener.volume -= 0.01f;
				hasScaled = false;
				transform.DOScale (new Vector2 (0.5f, 0.5f), 1.5f);
			}

			
			if (CameraMove.scene == "7" || CameraMove.scene == "9" || CameraMove.scene == "2" || CameraMove.scene == "4" || CameraMove.scene == "12" || CameraMove.scene == "14")
				gameObject.GetComponent<Renderer> ().material.color = blue;
			if (CameraMove.scene == "8" || CameraMove.scene == "3" || CameraMove.scene == "13")
				gameObject.GetComponent<Renderer> ().material.color = red;
			if (CameraMove.scene == "1" || CameraMove.scene == "5" || CameraMove.scene == "6" || CameraMove.scene == "10" || CameraMove.scene == "11" || CameraMove.scene == "15")
				gameObject.GetComponent<Renderer> ().material.color = white;
		} else {
			
			if (hasScaled == false) {
				if (gameObject.name == "MiddleScene" && PlayerPrefs.GetInt ("Sound") == 1)
					AudioCenter.playSound (soundId);
				transform.localScale = new Vector2 (0.5f, 0.5f);
				hasScaled = true;

			}
			if (gameObject.name == "MiddleScene" && PlayerPrefs.GetInt ("Sound") == 1)
				AudioListener.volume += 0.03f;
			transform.DOScale (Vector2.zero, 1f);
			if (transform.localScale.x <= 0.1f)
				PlayerPrefs.SetString("lastscene", "0");
			
		}
	}
}
