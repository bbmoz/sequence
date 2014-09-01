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
			if( Vector3.Distance(gameObject.transform.position, GameManager.lastNode.transform.position) <= 1.5) {
				int lastNodeTexture = int.Parse(GameManager.lastNode.tag);
				int currNodeTexture = int.Parse(gameObject.renderer.tag);

				if(GameManager.direction == 0) {
					if(lastNodeTexture - currNodeTexture == 1)
					{
						//Allows for reverse sequences i.e 6,5,4,3,2,1.
						//GameManager.direction = -1;
					}
					else if(lastNodeTexture - currNodeTexture == -1)
					{
						GameManager.direction = 1;
					}
				}

				if(GameManager.direction != 0) {
					if( lastNodeTexture - currNodeTexture + GameManager.direction == 0) {
						renderer.material.color = GameManager.newColor;
						GameManager.nodes.Add(gameObject);
						GameManager.lastNode = gameObject;
					}
				}
			}
		}
	}

	void OnMouseUp() {
		foreach (GameObject node in GameManager.nodes) {
			node.renderer.material.color = GameManager.oldColor;
			// remove and repopulate selected nodes
			if (GameManager.nodes.Count > 2) {
				print (GameManager.nodes.Count);
				node.GetComponent<NumberRandomization>().randomlyGenerateNumber();
			}
		}

		// calculate score
		ScoreBox.CalculateScore();

		GameManager.dragging = false;
		GameManager.nodes.Clear();

		// remove all clones of linerenderer
		foreach (Object clone in GameObject.FindGameObjectsWithTag("linerenderer")) {
			if (clone.name.Equals("LineRenderer(Clone)")) {
				Destroy(clone);
			}
		}
		GameManager.countTemp = 0;
		GameManager.direction = 0;
	}
}
