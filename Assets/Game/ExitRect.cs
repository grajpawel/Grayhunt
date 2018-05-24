using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class ExitRect : MonoBehaviour {
	
	private float timer;
	private bool hasHit;
	// Use this for initialization
	void Start () {
		hasHit = false;
		timer = 0;
		PlayGamesPlatform.Activate ();

	
	}
	
	// Update is called once per frame
	void Update () {
		if (hasHit == false)
		timer += Time.deltaTime;
		Debug.Log (timer * 1000);
	

		transform.Rotate (Vector3.forward);

	}
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.name == "Player") {
			if (SceneManager.GetActiveScene ().name == "Scene1") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQEA", (bool success) => {
					
				});			
			
				Social.ReportProgress ("CgkI9oaq2dELEAIQAQ", 100.0f, (bool success) => {
				});
			}

			if (SceneManager.GetActiveScene ().name == "Scene2") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQEQ", (bool success) => {
				});
			}

			if (SceneManager.GetActiveScene ().name == "Scene3") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQEg" , (bool success) => {
				});
			}

			if (SceneManager.GetActiveScene ().name == "Scene4") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQEw", (bool success) => {
				});
			}

			if (SceneManager.GetActiveScene ().name == "Scene5") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQFA", (bool success) => {
				});
			}

			if (SceneManager.GetActiveScene ().name == "Scene6") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQFQ", (bool success) => {
				});
			}

			if (SceneManager.GetActiveScene ().name == "Scene7") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQFg", (bool success) => {
				});
			}

			if (SceneManager.GetActiveScene ().name == "Scene9") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQGA", (bool success) => {
				});
			}

			if (SceneManager.GetActiveScene ().name == "Scene10") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQGQ", (bool success) => {
				});
			}

			if (SceneManager.GetActiveScene ().name == "Scene11") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQGg", (bool success) => {
				});
			}

			if (SceneManager.GetActiveScene ().name == "Scene12") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQGw", (bool success) => {
				});
			}

			if (SceneManager.GetActiveScene ().name == "Scene13") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQHA", (bool success) => {
				});
			}

			if (SceneManager.GetActiveScene ().name == "Scene14") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQHQ", (bool success) => {
				});
			}
			if (SceneManager.GetActiveScene ().name == "Scene15") {
				Social.ReportScore ((long)(timer * 1000), "CgkI9oaq2dELEAIQHg", (bool success) => {
				});
				Social.ReportProgress ("CgkI9oaq2dELEAIQDw", 0.0f, (bool success) => {
				});
			}
			hasHit = true;
			PlayerPrefs.SetInt (SceneManager.GetActiveScene ().name.ToString () + "Finish", 1);
			BackButton.OnTap ();
		}
	}
}
	
