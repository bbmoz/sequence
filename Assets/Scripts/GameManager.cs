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

	public LineRenderer lineRenderer;

	// Use this for initialization
	void Start () {
		dragging = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (nodes.Count>0 && nodes.Count%2 == 0) {
			GameObject[] nodesArray = nodes.ToArray() as GameObject[];
			lineRenderer.SetPosition(0, nodesArray[nodesArray.Length-2].transform.position);
			lineRenderer.SetPosition(1, nodesArray[nodesArray.Length-1].transform.position);
			Instantiate(lineRenderer);
		}
	}
}
