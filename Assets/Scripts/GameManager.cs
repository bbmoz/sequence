using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	// Static, hide from Inspector
	public static Color newColor = Color.blue;
	public static Color oldColor = Color.white;
	public static ArrayList nodes = new ArrayList();
	public static bool dragging;
	public static GameObject lastNode;
	public static int direction;
	public static int countTemp;
	public static int score;
	public static GameObject[,] spawnGrid;

	// Inspector
	public LineRenderer lineRenderer;
	public GameObject node;
	public int rows;
	public int cols;

	// Use this for initialization
	void Start () {
		// Initialization of variables
		dragging = false;
		countTemp = 0;
		score = 0;
		direction = 0;
		nodes.Clear();
		spawnGrid = new GameObject[cols,rows];

		// create grid of nodes
		Vector3 offset = new Vector3(-cols/2.0f+1.0f, -rows/2.0f+1.0f, 0.0f);
		for (int i=0; i<rows; i++) {
			for (int j=0; j<cols; j++) {
				spawnGrid[j,i] = Instantiate(node, new Vector3(j,i,0.0f)+offset, Quaternion.Euler(0,120,0)) as GameObject;
				print("j="+j+", i="+i+spawnGrid[j,i]);
			}
		}

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
