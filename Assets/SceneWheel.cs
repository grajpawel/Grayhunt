using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class SceneWheel : MonoBehaviour {
	public Color blue;
	public Color red;
	public Color white;
	public int scaleTarget;
	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().enabled = true;
		PlayerPrefs.SetString("lastscene", CameraMove.scene);
		if (CameraMove.scene == "7" || CameraMove.scene == "9" || CameraMove.scene == "2" || CameraMove.scene == "4" || CameraMove.scene == "12" || CameraMove.scene == "14")
			gameObject.GetComponent<Renderer> ().material.color = blue;
		if (CameraMove.scene == "8" || CameraMove.scene == "3" || CameraMove.scene == "13")
			gameObject.GetComponent<Renderer> ().material.color = red;
		if (CameraMove.scene == "1" || CameraMove.scene == "5" || CameraMove.scene == "6" || CameraMove.scene == "10" || CameraMove.scene == "11" || CameraMove.scene == "15")
			gameObject.GetComponent<Renderer> ().material.color = white;
	}
	
	// Update is called once per frame
	void Update () {
		if (AudioListener.volume >= 1)
			AudioListener.volume = 1;
		if (AudioListener.volume <= 0)
			AudioListener.volume = 0;
		if (CameraMove.scene != "0") {
			if (SceneManager.GetActiveScene ().name == ("Scene" + CameraMove.scene.ToString ())) {
				if (PlayerPrefs.GetInt ("Sound") == 1)
				AudioListener.volume += 0.03f;					
				transform.DOScale (Vector2.zero, 1);
			}
		} else {
			if (PlayerPrefs.GetInt ("Sound") == 1)
			AudioListener.volume -= 0.01f;
			transform.DOScale (new Vector2 (scaleTarget, scaleTarget), 0.75f);
			if (transform.localScale.x >= scaleTarget * 0.99f)
				SceneManager.LoadScene ("Scene0");
		}
	}
}
