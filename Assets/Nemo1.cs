using UnityEngine;
using System.Collections;

public class Nemo1 : MonoBehaviour {
	string currentRoom = "underthesea";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "";
		if (currentRoom == "underthesea") {
			textBuffer = "Finding Nemo adventure!";
			currentRoom = "first";
		}
		else if (currentRoom == "first") {
			textBuffer = "Encounters a shark! \nPress [A] to attack. \nPress [B] to ask for help. ";
			if (Input.GetKeyDown (KeyCode.A) ) {
				currentRoom = "attack";
			}
			if (Input.GetKeyDown (KeyCode.B) ) {
				currentRoom = "help";
			}
		}
		
		else if (currentRoom == "attack") {
			textBuffer = "Not strong enough, you are dead, can’t find nemo.";
		}
		
		else if (currentRoom == "help") {
			textBuffer = "The shark will give you directions, you can find nemo! ";
			
		}
		
		GetComponent <TextMesh> ().text = textBuffer;
	}
}
