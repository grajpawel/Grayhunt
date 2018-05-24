using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMesh : MonoBehaviour {
	public Transform floor;
	public int limit;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < limit; i++) {
			Instantiate (floor, new Vector2 (this.transform.position.x + i * 6, this.transform.position.y + i * 3), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
			
	}
}
