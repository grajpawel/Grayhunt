using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MiddleSceneBg2 : MonoBehaviour {
	public Color blue;
	public Color red;
	public Color white;
	private bool hasScaled;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Debug.Log (PlayerPrefs.GetString("lastscene"));
		Debug.Log (hasScaled);
		if (PlayerPrefs.GetString("lastscene") == "0"){
			if (CameraMove.scene != "0") {
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
			if (transform.localScale.x <= 0.1)
				PlayerPrefs.SetString("lastscene", "0");

			if (hasScaled == false) {
				transform.localScale = new Vector2 (0.5f, 0.5f);
				hasScaled = true;

			}

			transform.DOScale (Vector2.zero, 1.5f);
		}
	}
}
