using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraMove13 : MonoBehaviour {
	public float delay;
	public static float timer;
	public float moveTime;
	public float endDistance = -10;
	public float startDistance = -10;

	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > delay) {
			transform.DOMove (new Vector3 (GameObject.Find ("Player").transform.position.x, GameObject.Find ("Player").transform.position.y, endDistance), moveTime);
		} else {
			transform.DOMove (new Vector3 (GameObject.Find ("Player").transform.position.x, GameObject.Find ("Player").transform.position.y, startDistance), moveTime);
		}
	}

	
}
