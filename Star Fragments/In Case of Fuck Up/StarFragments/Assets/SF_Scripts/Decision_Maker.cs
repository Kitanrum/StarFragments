using UnityEngine;
using System.Collections;

public class Decision_Maker : MonoBehaviour {
	//public GameObject narText;
	//public GameObject iduText; These are meant for
	public GUITexture prompt;//Idunna
	public GUITexture eButton;
	public GUIText hello;//Empty

	public GUIText choice1; //Choice options
	public GUIText choice2;
	public GUIText choice3;
	public GUIText choice4;

	void Awake(){

		Dialoguer.Initialize();
	}
	// Use this for initialization
	void Start () {
		//hello.enabled = false;
		//choice1.enabled = false;
		//choice2.enabled = false;
		//choice3.enabled = false;
		//choice4.enabled = false;
		prompt.enabled = false;
		eButton.enabled = false;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

		void OnTriggerEnter(Collider col){

		if (col.gameObject.name == "Story1"){
			if(GUI.Button (new Rect(10,10,100,30), "Start!")){

				// The preferred way to start dialogues is with the DialoguerDialogues enum
				Dialoguer.StartDialogue(0);
				// By default, this enum is automatically updated when you save your dialogues.
				// You can turn this off in the Dialoguer preferences menu.

				// Another way to start a Dialogue is with the index id of the dialogue you wish to start, like so:
				//Dialoguer.StartDialogue(2);
				// But be careful, because if any dialogues are moved, this number must be changed too

			  }
		}

		if (col.gameObject.name == "Story2"){
			if(GUI.Button (new Rect(10,10,100,30), "Start!")){

				// The preferred way to start dialogues is with the DialoguerDialogues enum
				Dialoguer.StartDialogue(1);
				// By default, this enum is automatically updated when you save your dialogues.
				// You can turn this off in the Dialoguer preferences menu.

				// Another way to start a Dialogue is with the index id of the dialogue you wish to start, like so:
				//Dialoguer.StartDialogue(2);
				// But be careful, because if any dialogues are moved, this number must be changed too

			  }
		}

		if (col.gameObject.name == "Story3"){
			if(GUI.Button (new Rect(10,10,100,30), "Start!")){

				// The preferred way to start dialogues is with the DialoguerDialogues enum
				Dialoguer.StartDialogue(2);
				// By default, this enum is automatically updated when you save your dialogues.
				// You can turn this off in the Dialoguer preferences menu.

				// Another way to start a Dialogue is with the index id of the dialogue you wish to start, like so:
				//Dialoguer.StartDialogue(2);
				// But be careful, because if any dialogues are moved, this number must be changed too

			  }
		}
	


		if (col.gameObject.name == "Story4"){
			if(GUI.Button (new Rect(10,10,100,30), "Start!")){

				// The preferred way to start dialogues is with the DialoguerDialogues enum
				Dialoguer.StartDialogue(3);
				// By default, this enum is automatically updated when you save your dialogues.
				// You can turn this off in the Dialoguer preferences menu.

				// Another way to start a Dialogue is with the index id of the dialogue you wish to start, like so:
				//Dialoguer.StartDialogue(2);
				// But be careful, because if any dialogues are moved, this number must be changed too

			  }
		}

		if (col.gameObject.name == "Story5"){
			if(GUI.Button (new Rect(10,10,100,30), "Start!")){

				// The preferred way to start dialogues is with the DialoguerDialogues enum
				Dialoguer.StartDialogue(4);
				// By default, this enum is automatically updated when you save your dialogues.
				// You can turn this off in the Dialoguer preferences menu.

				// Another way to start a Dialogue is with the index id of the dialogue you wish to start, like so:
				//Dialoguer.StartDialogue(2);
				// But be careful, because if any dialogues are moved, this number must be changed too

			  }
		}

		if (col.gameObject.name == "Story6"){
			if(GUI.Button (new Rect(10,10,100,30), "Start!")){

				// The preferred way to start dialogues is with the DialoguerDialogues enum
				Dialoguer.StartDialogue(5);
				// By default, this enum is automatically updated when you save your dialogues.
				// You can turn this off in the Dialoguer preferences menu.

				// Another way to start a Dialogue is with the index id of the dialogue you wish to start, like so:
				//Dialoguer.StartDialogue(2);
				// But be careful, because if any dialogues are moved, this number must be changed too

			  }
		}
}
		//void OnTriggerEnter(Collider col){

		//if (col.gameObject.name == "Story1"){
			
		//}


	//}
	
}