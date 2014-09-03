using UnityEngine;
using System.Collections;

public class ClockBehavior : MonoBehaviour {

	private int timeToComplete = 10;
	private GameObject clockMask, clockEnd;

	// Use this for initialization
	void Start () {
		clockMask = GameObject.Find("ClockMask");
		clockEnd = GameObject.Find("ClockEnd");

		StartCoroutine(ClockUpdate(timeToComplete));
	}
	
	IEnumerator ClockUpdate(float time)
	{
		float rate = 1 / time;
		float fractionComplete = 0;
		while (fractionComplete < 1)
		{
			fractionComplete += rate * Time.deltaTime;

			if(fractionComplete > 1) {
				Application.LoadLevel("gameoverscreen");
			}

			if(fractionComplete < 0.5f) {
				clockMask.transform.rotation = Quaternion.Euler(0, 0, -360*fractionComplete);
			}
			else {
				clockMask.SetActive(false);
				clockEnd.transform.rotation = Quaternion.Euler(0, 0, -360*(fractionComplete-0.5f));
			}

			yield return 0;
		}
	}
}
