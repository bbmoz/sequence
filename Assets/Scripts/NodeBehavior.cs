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
			GameManager.lastNode = gameObject;
			print(gameObject.transform.position);


			GameManager.nodes.Add(gameObject);

		}
	}

	// successive nodes
	void OnMouseOver() {
		if (GameManager.dragging && GameManager.nodes.Count > 0 && renderer.material.color != GameManager.newColor) {

			//print(GameManager.nodes.Count);

//			print (gameObject.transform.position);
//			print (GameManager.lastNode.transform.position);
//			print (Vector3.Distance(gameObject.transform.position, GameManager.lastNode.transform.position));
			if( Vector3.Distance(gameObject.transform.position, GameManager.lastNode.transform.position) <= 1.5) {
				renderer.material.color = GameManager.newColor;
				GameManager.nodes.Add(gameObject);
				GameManager.lastNode = gameObject;
			}
//			foreach (GameObject node in GameManager.nodes) {
//				print(node.renderer.material.mainTexture);
//			}


			//if( Vector3.Distance(gameObject.transform.position, GameManager.lastNode.transform.position) <= 2^.5)
			//print(gameObject.transform.position);

			renderer.material.color = GameManager.newColor;
			GameManager.nodes.Add(gameObject);

		}
	}

	void OnMouseUp() {
		foreach (GameObject node in GameManager.nodes) {
			node.renderer.material.color = GameManager.oldColor;
		}
		GameManager.dragging = false;
		GameManager.nodes.Clear();

		// remove all clones of linerenderer
		foreach (Object clone in GameObject.FindGameObjectsWithTag("linerenderer")) {
			if (clone.name.Equals("LineRenderer(Clone)")) {
				Destroy(clone);
			}
		}
		GameManager.countTemp = 0;
	}
}
