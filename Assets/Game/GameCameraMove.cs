using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class GameCameraMove : MonoBehaviour {
	public float CamSize = 5;
	public float moveTime = 1;
	public static float timer;
	public float sizeTime = 1;
	public float delay = 1;
	private int soundId;
	private bool hasPlayed;
	// Use this for initialization
	void Start () {
		soundId = AudioCenter.loadSound ("woosh2");

		hasPlayed = false;
		timer = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		timer += Time.deltaTime;
		transform.DOMove (new Vector3 (GameObject.Find ("Player").transform.position.x, GameObject.Find ("Player").transform.position.y, -10), moveTime);
		if (timer >= delay) {
			GetComponent<Camera> ().DOOrthoSize (CamSize, sizeTime);
			if (PlayerPrefs.GetInt ("Sound") == 1) {
				if (hasPlayed == false) {
					AudioCenter.playSound (soundId);
					hasPlayed = true;
				}
			}
		}
	}
}
