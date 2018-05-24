using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollectibleTeleport : MonoBehaviour {
	public Vector2 TeleportPos;
	public static bool tpWater;
	// Use this for initialization
	void Start () {
		tpWater = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate (Vector3.forward);

			
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Player") {
			col.gameObject.transform.position = TeleportPos;
			if (SceneManager.GetActiveScene ().name == "Scene3") {
				GameObject.Find ("Player").transform.localScale = new Vector2 (0.5f, 0.5f);
				tpWater = true;
			}
		}
	}
}
