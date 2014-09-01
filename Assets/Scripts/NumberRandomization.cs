using UnityEngine;
using System.Collections;

public class NumberRandomization : MonoBehaviour {

	// Inspector
	public Texture[] NumberTextures;

	// Use this for initialization
	void Start () {
		randomlyGenerateNumber();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void randomlyGenerateNumber() {
		// Set a random texture onto the node
		int pos = Random.Range(0,6);
		renderer.material.mainTexture = NumberTextures[pos];
		tag = (pos + 1).ToString();
	}
}
