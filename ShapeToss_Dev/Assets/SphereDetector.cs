using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereDetector : MonoBehaviour {
	public Text sphereText;

	private int sphereScore;
	private int numSpheres;

	// Use this for initialization
	void Start () {
		sphereScore = 0;
		numSpheres = 7;
		updateText ();
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Sphere")) {
			sphereScore++;
			updateText ();
		}
	}

	void updateText() {
		sphereText.text = "Spheres: " + sphereScore + "/" + numSpheres;
	}
}
