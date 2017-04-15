using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
	public Text victoryText;

	// Use this for initialization
	void Start ()
	{
		victoryText.gameObject.SetActive (false);
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Exit"))
			victoryText.gameObject.SetActive (true);
	}

}
