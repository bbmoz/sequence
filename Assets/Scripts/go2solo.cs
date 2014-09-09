using UnityEngine;
using System.Collections;

public class go2solo : MonoBehaviour {

	public Texture2D playNormal;
	public Texture2D playHover;
	public AudioClip sound;
	public float buttonDelay = 0.3333f;

	private float timestamp;
	// Use this for initialization
	void Start () {
		
	}
	void OnMouseEnter () {
		
		guiTexture.texture = playHover;
		audio.PlayOneShot(sound);
	}
	
	void OnMouseDown () {
		Application.LoadLevel ("solomenu");
		if (Time.time >= timestamp && Input.GetMouseButtonDown(1));
		{
			timestamp = Time.time + buttonDelay;
		}
	}
	
	void OnMouseExit () {
		
		guiTexture.texture = playNormal;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
