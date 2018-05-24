using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class CameraMove : MonoBehaviour {
	
	public static string scene;

	void Start () {
		 
		scene = "0";
	}

	// Update is called once per frame
	void Update () {
		if (FrontSwipe.frontScene == 0)
			transform.DOMove (Vector3.zero, 1);
		if (FrontSwipe.frontScene == 1) {
			PlayerPrefs.SetInt("HasSwiped", 1);
			transform.DOMove (new Vector3 (-21, 0, 0), 1);
		}
		if (Input.GetKey("escape") || Input.GetButton("Cancel"))
			Application.Quit();

	
		if (GameObject.Find ("MiddleScene").transform.localScale.x >= 0.49f) 
			

				SceneManager.LoadScene ("Scene" + scene.ToString ());


				
		}
}
