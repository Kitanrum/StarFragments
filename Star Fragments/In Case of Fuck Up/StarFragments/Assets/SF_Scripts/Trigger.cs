using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	void Awake(){
		Dialoguer.Initialize(); //starts dialoguer
	}

	// Use this for initialization
	void Start () {
	Dialoguer.StartDialogue(0, dialoguerCallback);
	}
	
	// Update is called once per frame
	void Update () {

		
	
	}

	/*void OnGUI(){
		if (GUI.Button(new Rect(10,10,100,20), "Start Dialoguer")){

			Dialoguer.StartDialogue(0, dialoguerCallback);
			this.enabled = false;

			>>Use this if you want just a plain text adventure.

		} 
	}*/

	void OnTriggerEnter(Collider col) {

		if(col.gameObject.name == "Story1"){ //if colliding with game object with this name, do the following
			
			print("boop"); //beep

			Dialoguer.StartDialogue(1, dialoguerCallback); //begins the dialogue, the option for callback
			this.enabled = false; //enable the callback;

		}

		if(col.gameObject.name == "Story2"){
			
			print("bleep");

			Dialoguer.StartDialogue(2, dialoguerCallback);
			this.enabled = false;

		}

		if(col.gameObject.name == "Story3"){
			
			print("bleep");

			Dialoguer.StartDialogue(3, dialoguerCallback);
			this.enabled = false;

		}

		if(col.gameObject.name == "Story4"){
			
			print("bleep");

			Dialoguer.StartDialogue(4, dialoguerCallback);
			this.enabled = false;

		}
	}

	private void dialoguerCallback(){
		this.enabled = true;
	}
}
