using UnityEngine;
using System.Collections;

public class Columnspawner : MonoBehaviour {
	public GameObject column;
	public float colX;

	// Use this for initialization
	void Start () {
		for (float colX = -3.0f; colX <= 60; colX += 5){
			Vector3 pos_back = new Vector3(colX, -.2f, -3);
			Instantiate(column, pos_back, Quaternion.identity);
		}

		for (float colX = -0.6f; colX <= 60; colX += 5){
			Vector3 pos_fore = new Vector3(colX, -1, -7);
			Instantiate(column, pos_fore, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
