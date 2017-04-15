using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour {

	public Text victoryText;

	// Use this for initialization
	void Start () {
		victoryText.gameObject.SetActive (false);
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Finish"))
			victoryText.gameObject.SetActive (true);
	}
}
