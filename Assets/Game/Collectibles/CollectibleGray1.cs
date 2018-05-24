using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class CollectibleGray1 : MonoBehaviour {
	public Text score;
	private int soundId;
	// Use this for initialization
	void Start () {
		PlayGamesPlatform.Activate ();

	
		soundId = AudioCenter.loadSound ("pickup");
		SetScore ();
		if (PlayerPrefs.GetInt (SceneManager.GetActiveScene ().name + gameObject.name) == 1)
			Destroy (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate (Vector3.forward);
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Player") {
			if (PlayerPrefs.GetInt ("Sound") == 1)
			AudioCenter.playSound (soundId);

			//number of collected things
			PlayerPrefs.SetInt (SceneManager.GetActiveScene ().name.ToString(), PlayerPrefs.GetInt(SceneManager.GetActiveScene().name.ToString()) + 1);
			PlayerPrefs.SetInt (SceneManager.GetActiveScene ().name.ToString() + gameObject.name.ToString(), 1);
			SetScore ();

			if (SceneManager.GetActiveScene().name == "Scene2"){
									
				PlayGamesPlatform.Instance.IncrementAchievement(
					"CgkI9oaq2dELEAIQAg", 1, (bool success) => {
				});
			}

			if (SceneManager.GetActiveScene().name == "Scene3"){
				PlayGamesPlatform.Instance.IncrementAchievement(
					"CgkI9oaq2dELEAIQAw", 1, (bool success) => {
					});
			}

			if (SceneManager.GetActiveScene().name == "Scene4"){
				PlayGamesPlatform.Instance.IncrementAchievement(
					"CgkI9oaq2dELEAIQBA", 1, (bool success) => {
					});
			}

			if (SceneManager.GetActiveScene().name == "Scene5"){
				PlayGamesPlatform.Instance.IncrementAchievement(
					"CgkI9oaq2dELEAIQBQ", 1, (bool success) => {
					});
			}

		
			if (SceneManager.GetActiveScene().name == "Scene6"){
				PlayGamesPlatform.Instance.IncrementAchievement(
					"CgkI9oaq2dELEAIQBg", 1, (bool success) => {
					});
			}

			if (SceneManager.GetActiveScene().name == "Scene7"){
				PlayGamesPlatform.Instance.IncrementAchievement(
					"CgkI9oaq2dELEAIQBw", 1, (bool success) => {
					});
			}

			if (SceneManager.GetActiveScene().name == "Scene9"){
				PlayGamesPlatform.Instance.IncrementAchievement(
					"CgkI9oaq2dELEAIQCA", 1, (bool success) => {
					});
			}

			if (SceneManager.GetActiveScene().name == "Scene10"){
				PlayGamesPlatform.Instance.IncrementAchievement(
					"CgkI9oaq2dELEAIQCQ", 1, (bool success) => {
					});
			}

			if (SceneManager.GetActiveScene().name == "Scene11"){
				PlayGamesPlatform.Instance.IncrementAchievement(
					"CgkI9oaq2dELEAIQCg", 1, (bool success) => {
					});
			}

			if (SceneManager.GetActiveScene().name == "Scene12"){
				PlayGamesPlatform.Instance.IncrementAchievement(
					"CgkI9oaq2dELEAIQCw", 1, (bool success) => {
					});
			}

			if (SceneManager.GetActiveScene().name == "Scene13"){
				PlayGamesPlatform.Instance.IncrementAchievement(
					"CgkI9oaq2dELEAIQDA", 1, (bool success) => {
					});
			}

			if (SceneManager.GetActiveScene().name == "Scene14"){
				PlayGamesPlatform.Instance.IncrementAchievement(
					"CgkI9oaq2dELEAIQDQ", 1, (bool success) => {
					});
			}

			if (SceneManager.GetActiveScene().name == "Scene15"){
				PlayGamesPlatform.Instance.IncrementAchievement(
					"CgkI9oaq2dELEAIQDg", 1, (bool success) => {
					});
			}
					

					
			transform.position = new Vector2 (1000, 1000);
		}
	}
	void SetScore(){
		score.text = (PlayerPrefs.GetInt (SceneManager.GetActiveScene ().name.ToString()) + " / 3");
	}

}
