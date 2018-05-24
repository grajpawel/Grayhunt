using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextColor : MonoBehaviour {
	private Text text;
	public Color Color1;
	public Color Color2;
	public Color Color3;
	public Color Color4;
	public Color Color5;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (RocketPlatform.color == 1)
			text.color = Color1;
		if (RocketPlatform.color == 2)
			text.color = Color2;
		if (RocketPlatform.color == 3)
			text.color = Color3;
		if (RocketPlatform.color == 4)
			text.color = Color4;
		if (RocketPlatform.color == 5)
			text.color = Color5;
	}
}
