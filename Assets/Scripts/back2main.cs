using UnityEngine;
using System.Collections;

public class back2main : MonoBehaviour {

	public Texture2D playNormal;
	public Texture2D playHover;
	public AudioClip sound;
	// Use this for initialization
	void Start () {
		
	}
	void OnMouseEnter () {
		
		guiTexture.texture = playHover;
		audio.PlayOneShot(sound);
	}
	
	void OnMouseDown () {
		Application.LoadLevel ("mainmenu");
	}
	
	void OnMouseExit () {
		
		guiTexture.texture = playNormal;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

