using UnityEngine;
using System.Collections;

public class back2main : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnMouseDown () {
			Application.LoadLevel("mainmenu");
	}
	// Update is called once per frame
	void Update () {
	}
}
