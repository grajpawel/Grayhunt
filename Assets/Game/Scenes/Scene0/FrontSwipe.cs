using UnityEngine;
using System.Collections;


public class FrontSwipe : MonoBehaviour {
	private float fingerStartTime  = 0.0f;
	private Vector2 fingerStartPos = Vector2.zero;
	public static int frontScene = 0;
	private bool isSwipe = false;
	private float minSwipeDist  = 50.0f;
	private float maxSwipeTime = 1f;
	public static int scene = 1;
	private bool hasTpdVer = false;
	private bool hasTpdHor = false;
	private int soundId;
	private int wooshSound;
	private int swooshPlay = 1;

	// Use this for initialization
	void Start () {
		soundId = AudioCenter.loadSound ("mouse2");
		wooshSound = AudioCenter.loadSound ("woosh2");
	}

	// Update is called once per frame
	void Update () {
		
		Debug.Log (scene);
		if (frontScene == 1) {
			if (swooshPlay == 1) {
				if (PlayerPrefs.GetInt ("Sound") == 1)					
				AudioCenter.playSound (wooshSound);
				swooshPlay--;
			}
		}
		if (frontScene == 0) {
			if (swooshPlay == 0) {
				if (PlayerPrefs.GetInt ("Sound") == 1)
				AudioCenter.playSound (wooshSound);
				swooshPlay++;
			}
		}
	

		if (scene == 0 || scene == -1 || scene == -2)
				frontScene = 1;
			else
				frontScene = 0;
	
		if (hasTpdHor == false) {
			
			if (Input.GetAxis ("Horizontal") >= 0.2f){
				if (scene != 0) {
					if (PlayerPrefs.GetInt ("Sound") == 1)
						AudioCenter.playSound (soundId);
				}
				scene++;
				hasTpdHor = true;
			}
			if (Input.GetAxis ("Horizontal") <= -0.2f) {
				if (scene != 1) {
					if (PlayerPrefs.GetInt ("Sound") == 1)
						AudioCenter.playSound (soundId);
				}
				scene--;
				hasTpdHor = true;
			}
		}
		if (hasTpdVer == false){
			if (Input.GetAxis ("Vertical") <= -0.2f) {
				if (scene != 0) {
					if (PlayerPrefs.GetInt ("Sound") == 1)
						AudioCenter.playSound (soundId);
				}
				scene += 5;
				hasTpdVer = true;
			}
			if (Input.GetAxis ("Vertical") >= 0.2f) {
				if (scene != 0) {
					if (PlayerPrefs.GetInt ("Sound") == 1)
						AudioCenter.playSound (soundId);
				}
				scene -= 5;
				hasTpdVer = true;
			}
		}
		if (Input.GetAxis ("Horizontal") == 0)
			hasTpdHor = false;
		if (Input.GetAxis ("Vertical") == 0)
			hasTpdVer = false;
		
		if (scene < -2)
			scene = 16;
		if (scene > 16)
			scene = 1;
		



		if (Input.touchCount == 0)
			return;
		if (Input.touchCount > 0){

			foreach (Touch touch in Input.touches)
			{
				switch (touch.phase)
				{
				case TouchPhase.Began :
					/* this is a new touch */
					isSwipe = true;
					fingerStartTime = Time.time;
					fingerStartPos = touch.position;
					break;

				case TouchPhase.Canceled :
					/* The touch is being canceled */
					isSwipe = false;
					break;

				case TouchPhase.Ended :

					float gestureTime = Time.time - fingerStartTime;
					float gestureDist = (touch.position - fingerStartPos).magnitude;

					if (isSwipe && gestureTime < maxSwipeTime && gestureDist > minSwipeDist){
						Vector2 direction = touch.position - fingerStartPos;
						Vector2 swipeType = Vector2.zero;

						if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y)){
							// the swipe is horizontal:
							swipeType = Vector2.right * Mathf.Sign(direction.x);
						}else{
							// the swipe is vertical:
							swipeType = Vector2.up * Mathf.Sign(direction.y);
						}

						if(swipeType.x != 0.0f){
							if(swipeType.x > 0.0f){
									// MOVE RIGHT
								frontScene = 1;
								scene = 0;
							}else{
								frontScene = 0;
								scene = 1;
								// MOVE LEFT
							}
						}

						if(swipeType.y != 0.0f ){
							if(swipeType.y > 0.0f){


								// MOVE UP
							}else{


								// MOVE DOWN
							}
						}

					}

					break;
				}
			}
		}

	}
}
