using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	
	void OnControllerColliderHit(ControllerColliderHit hit) {
		// ONLY CONTROLS COLLISIONS IF THE CONTROLLER IS "MOVING"
		if (hit.gameObject.name == "AUTO" && hit.gameObject.transform.position.y > this.transform.position.y) {
			Application.LoadLevel ("GameOver");
		}
	}
}
