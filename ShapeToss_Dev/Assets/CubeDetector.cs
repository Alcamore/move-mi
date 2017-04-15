using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeDetector : MonoBehaviour {
	public Text cubeText;

	private int cubeScore;
	private int numCubes;

	// Use this for initialization
	void Start () {
		cubeScore = 0;
		numCubes = 7;
		updateText ();
	}
		
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Cube")) {
			cubeScore++;
			updateText ();
		}
	}

	void updateText() {
		cubeText.text = "Cubes: " + cubeScore + "/" + numCubes;
	}
}
