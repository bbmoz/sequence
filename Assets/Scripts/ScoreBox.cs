using UnityEngine;
using System.Collections;

public class ScoreBox : MonoBehaviour {

	public GameObject scoreBox;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI() {
		scoreBox.GetComponent<GUIText>().text = GameManager.score.ToString();
	}

	public static void CalculateScore() {
		int numNodes = GameManager.nodes.Count-1;
		GameManager.score += (numNodes*numNodes-numNodes)/2;
	}
}
