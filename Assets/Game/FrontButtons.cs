using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class FrontButtons : MonoBehaviour {
	private string ButtonCount;
	public Sprite zero;
	public Sprite one;
	public Sprite two;
	public Sprite three;

	private Button button;
	private int intname;
	private float AccelX;
	// Use this for initialization
	void Awake (){
		button = GetComponent<Button> ();
	}
	void Start () {
		
		ButtonCount = gameObject.name;
		int.TryParse (ButtonCount, out intname);
	}
	
	// Update is called once per frame
	void Update () {
		//transform.DOLocalRotate (new Vector3 (0, 0, Input.acceleration.x * 60), 1, RotateMode.Fast);
		if (PlayerPrefs.GetInt("Scene" + gameObject.name) == 0)
			button.image.sprite = zero;
		if (PlayerPrefs.GetInt("Scene" + gameObject.name) == 1)
			button.image.sprite = one;
		if (PlayerPrefs.GetInt("Scene" + gameObject.name) == 2)
			button.image.sprite = two;
		if (PlayerPrefs.GetInt("Scene" + gameObject.name) == 3)
			button.image.sprite = three;
			
	}
	public void OnTap(){
		if (ButtonCount != "1") {
			
			if (PlayerPrefs.GetInt ("Scene" + (intname - 1).ToString () + "Finish") == 1)
				CameraMove.scene = ButtonCount;
		}
			else
			CameraMove.scene = ButtonCount;
	}
}
