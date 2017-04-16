using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class CameraController : MonoBehaviour {
	private Hand firstHand;

	// Update is called once per frame
	void Update () {
		Controller controller = new Controller ();
		Frame frame = controller.Frame (); // controller is a Controller object
		if(frame.Hands.Count > 0){
			List<Hand> hands = frame.Hands;
			firstHand = hands [0];
		}

		if (firstHand.PinchStrength == 1.0f) {
			Debug.Log ("Pinching");
			float[] fPos = firstHand.PalmVelocity.ToFloatArray ();
			Vector3 pos = new Vector3 (fPos [0], fPos[1], 0.0f);
			Debug.Log (pos.ToString());
			Debug.Log (transform.position.ToString ());
			pos.Normalize ();
			pos = Vector3.ProjectOnPlane (pos, Vector3.up);
			pos = -pos;
			//dir = Vector3.Cross (dir, Vector3.down);

			transform.Translate (pos / 100);
		}
	}
}
