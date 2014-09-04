using UnityEngine;
using System.Collections;

public class ButtonEventRefreshNodes : MonoBehaviour {
	// Creates An event ClickAction() and the associated broadcast event action OnPress
	public delegate void ClickAction();
	public static event ClickAction OnPress;

	//Creates a button that will broatcast OnPress when clicked
	void OnGUI () {
		if (GUI.Button (new Rect (335, 290, 60, 30), "Refresh")) {
			print("refresh button pressed");
			if(OnPress != null)
				OnPress();
		}
	}
}