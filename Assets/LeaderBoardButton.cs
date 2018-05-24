using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class LeaderBoardButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (FrontSwipe.scene == -1) {
			if (Input.GetButtonDown ("Submit")) {
				OnTap ();
			}
		}

	}
	public void OnTap(){
		Social.ShowLeaderboardUI();

	}
}
