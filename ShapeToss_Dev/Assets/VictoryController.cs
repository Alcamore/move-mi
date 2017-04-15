using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryController : MonoBehaviour {

	public Text cubeText;
	public Text sphereText;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (cubeText.text == "Cubes: 7/7" &&
		    sphereText.text == "Spheres: 7/7")
			gameObject.SetActive (true);
	}
}
