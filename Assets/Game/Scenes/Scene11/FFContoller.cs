using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFContoller : MonoBehaviour {
	public static int tick1;
	public static int tick2;
	public static int tick3;
	public static int tick4;
	public static int tick5;
	public static int tick6;
	private float timer;
	// Use this for initialization
	void Start () {
		tick1 = 1;
		tick2 = 2;
		tick3 = 3;
		tick4 = 4;
		tick5 = 5;
		tick6 = 6;
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		if (timer > 2) {
			if (tick1 == 6)
				tick1 = 1;
			else
			tick1++;
			if (tick2 == 6)
				tick2 = 1;
			else
				tick2++;
			if (tick3 == 6)
				tick3 = 1;
			else
				tick3++;
			if (tick4 == 6)
				tick4 = 1;
			else
				tick4++;
			if (tick5 == 6)
				tick5 = 1;
			else
				tick5++;
			if (tick6 == 6)
				tick6 = 1;
			else
				tick6++;
			timer = 0;
		}
	}
}
