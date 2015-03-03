using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	public static float xPoss;
	public float xpos;
	public float ypos;
	public float vel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		xPoss = transform.localPosition.x;
		vel = Time.deltaTime * 6.0f;
		xpos = Input.GetAxis("Horizontal") * vel;
		ypos = Input.GetAxis("Vertical") * vel;
		transform.Translate(-xpos, 0,0);
	
		if(xPoss >= 64.5f){
			transform.Translate(0.1f,0,0);
		}

		if(xPoss <= -0.01f){
			transform.Translate(-0.1f,0,0);
		}
	}
}
