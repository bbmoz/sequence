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


	public static GameObject lastNode;

	public static int direction = 0;

	public LineRenderer lineRenderer;

	[HideInInspector]
	public static int countTemp;

	[HideInInspector]
	public static int score;


	// Use this for initialization
	void Start () {
		dragging = false;
		countTemp = 0;
		score = 0;
		nodes.Clear();
	}
	
	// Update is called once per frame
	void Update () {
		if (nodes.Count>countTemp && nodes.Count>1) {
			countTemp = nodes.Count;
			lineRenderer.SetPosition(0, (nodes[nodes.Count-2] as GameObject).transform.position);
			lineRenderer.SetPosition(1, (nodes[nodes.Count-1] as GameObject).transform.position);
			Instantiate(lineRenderer);
		}
	}
}
