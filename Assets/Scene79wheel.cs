using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Scene79wheel : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("MiddleScene").transform.localScale.x >= 0.492f) {
			if (CameraMove.scene == "7" || CameraMove.scene == "9")
				transform.DOScale (Vector2.zero, 1);
		}
	}
}
