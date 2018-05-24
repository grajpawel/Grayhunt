using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CollectibleFloor: MonoBehaviour {
	public Text score;
	private int soundId;

	// Use this for initialization
	void Start () {
		soundId = AudioCenter.loadSound ("pickup");

		SetScore ();
		if (PlayerPrefs.GetInt (SceneManager.GetActiveScene ().name + gameObject.name) == 1)
			Destroy (this.gameObject);
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (GameObject.Find ("MovingFloor").transform.position.x, GameObject.Find ("MovingFloor").transform.position.y + 2);
		transform.Rotate (Vector3.forward);
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Player") {
			if (PlayerPrefs.GetInt ("Sound") == 1)
			AudioCenter.playSound (soundId);
			PlayerPrefs.SetInt (SceneManager.GetActiveScene ().name.ToString(), PlayerPrefs.GetInt(SceneManager.GetActiveScene().name.ToString()) + 1);
			PlayerPrefs.SetInt (SceneManager.GetActiveScene ().name.ToString() + gameObject.name.ToString(), 1);
			SetScore ();
			Destroy (this.gameObject);
		}
	}
	void SetScore(){
		score.text = (PlayerPrefs.GetInt (SceneManager.GetActiveScene ().name.ToString()) + " / 3");
	}

}
