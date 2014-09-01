using UnityEngine;
using System.Collections;

public class ClockBehavior : MonoBehaviour {

	public int timeToComplete = 90;
	
	// Use this for initialization
	void Start () {
		//Use this to Start progress
		StartCoroutine(ClockUpdate(timeToComplete));
	}
	
	IEnumerator ClockUpdate(float time)
	{
		float rate = 1 / time;
		float fractionComplete = 0;
		while (fractionComplete < 1)
		{
			fractionComplete += rate * Time.deltaTime;
			gameObject.renderer.material.SetFloat("_Cutoff", fractionComplete);
			yield return 0;
		}
	}
}
