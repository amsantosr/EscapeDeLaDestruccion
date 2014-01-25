using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour {
	private System.Random rnd;
	private int difficultyLimit;
	// Use this for initialization
	
	public Position() : base(){
		rnd = new System.Random ();
		difficultyLimit = 10;
	}
	
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		int randomNumber = rnd.Next (100);
		
		
		if (randomNumber < difficultyLimit) {
			GameObject gameObject = null;
			switch (rnd.Next() % 4) {
			case 0:
			{
				gameObject = GameObject.CreatePrimitive (PrimitiveType.Cube);
				break;
			}
			case 1:
			{
				gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
				break;
			}
			case 2:
			{
				gameObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
				break;
			}
			case 3:
			{
				gameObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
				break;
			}
			}
			gameObject.AddComponent<Rigidbody> ();
			gameObject.transform.position = new Vector3 (betweenRange(this.transform.position.x,2),this.transform.position.y+4.0f,betweenRange(this.transform.position.z,2));
			gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
			gameObject.transform.rotation = Random.rotation;
			gameObject.renderer.material.color = new Color((float)rnd.NextDouble(), (float)rnd.NextDouble(), (float)rnd.NextDouble());
			//Destroy(gameObject, 5);
		}
		
	}
	
	private float betweenRange(double number, double range){
		bool sign;
		double numToSum;
		if (rnd.Next (0, 100) < 50) {
			sign = false;
		} else {
			sign = true;
		}
		numToSum = rnd.NextDouble ()*range;
		if (!sign) {
			numToSum = numToSum * -1;
		}
		
		return (float)(numToSum + number);
	}
}
