using UnityEngine;
using System.Collections;

public class NodeBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// first node
	void OnMouseDrag() {
		if (renderer.material.color != GameManager.newColor) {
			GameManager.dragging = true;
			renderer.material.color = GameManager.newColor;
			GameManager.nodes.Add (gameObject);
		}
	}

	// successive nodes
	void OnMouseOver() {
		if (GameManager.dragging && GameManager.nodes.Count > 0 && renderer.material.color != GameManager.newColor) {
			print(GameManager.nodes.Count);
			renderer.material.color = GameManager.newColor;
			GameManager.nodes.Add(gameObject);
		}
	}

	void OnMouseUp() {
		foreach (GameObject node in GameManager.nodes) {
			node.renderer.material.color = GameManager.oldColor;
		}
		GameManager.dragging = false;
	}
}
