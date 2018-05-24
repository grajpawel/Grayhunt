using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class GooglePlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayGamesPlatform.Activate ();
		Social.localUser.Authenticate ((bool success) => {
		});
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("Scene1") == 3 && PlayerPrefs.GetInt ("Scene2") == 3 && PlayerPrefs.GetInt ("Scene3") == 3 && PlayerPrefs.GetInt ("Scene4") == 3 && PlayerPrefs.GetInt ("Scene5") == 3 && PlayerPrefs.GetInt ("Scene6") == 3 && PlayerPrefs.GetInt ("Scene7") == 3 && PlayerPrefs.GetInt ("Scene8") == 3 && PlayerPrefs.GetInt ("Scene9") == 3 && PlayerPrefs.GetInt ("Scene10") == 3 && PlayerPrefs.GetInt ("Scene11") == 3 && PlayerPrefs.GetInt ("Scene12") == 3 && PlayerPrefs.GetInt ("Scene13") == 2 && PlayerPrefs.GetInt ("Scene14") == 3 && PlayerPrefs.GetInt ("Scene15") == 3) {
			Social.ReportProgress ("CgkI9oaq2dELEAIQDw", 100.0f, (bool success) => {
			});
		}
	}
}
