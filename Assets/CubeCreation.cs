using UnityEngine;
using System.Collections;

public class CubeCreation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for (int i=0; i<5; i++) {
			GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cube.AddComponent<Rigidbody> ();
			cube.transform.position = new Vector3 (i*2 , 4, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {	
	}
}
