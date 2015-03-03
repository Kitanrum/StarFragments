using UnityEngine;
using System.Collections;

public class Story : MonoBehaviour {

	private bool _showing; //bool to show text

	private string _text; //text container
	private string[] _choices; //allows choices

	// Use this for initialization
	void Start () {

		Dialoguer.events.onStarted += onStarted; //starting
		Dialoguer.events.onEnded += onEnded; //ending
		Dialoguer.events.onTextPhase += onTextPhase; //during text
	
	}
	
	void OnGUI(){

		if (!_showing) //if showing is true do this
			return;

		
		GUI.Box(new Rect(10,10,200,150), _text); //box for text

		if(_choices == null){ //allows for advancing

			if (GUI.Button (new Rect(10,220,200,30), "continue")){

				Dialoguer.ContinueDialogue(); //advance

			}
		
		}

		else{
						  // allows for choice tree
			for(int i=0; i < _choices.Length; i++){

				if (GUI.Button (new Rect(10,220 + (40*i), 200, 30), _choices[i])){

					Dialoguer.ContinueDialogue(i); //pick choice to advance

				}

			}

		}

	}

	private void onStarted(){

		_showing = true; //shows

	}

	private void onEnded(){

		_showing = false; //hides

	}

	private void onTextPhase(DialoguerTextData data){

		_text = data.text; 
		_choices = data.choices;

	}
}