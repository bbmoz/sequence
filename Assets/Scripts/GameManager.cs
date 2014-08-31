using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	[HideInInspector]
	public static Color newColor = Color.blue;
	[HideInInspector]
	public static Color oldColor = Color.green;
	
	[HideInInspector]
	public static ArrayList nodes = new ArrayList();

	[HideInInspector]
	public static bool dragging;

	// Use this for initialization
	void Start () {
		dragging = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
