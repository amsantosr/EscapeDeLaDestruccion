﻿using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour {
	private System.Random rnd;
	private int difficultyLimit;
	// Use this for initialization
	
	public Position() : base(){
		rnd = new System.Random ();
		difficultyLimit = 2;
	}
	
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		int randomNumber = rnd.Next (100);
		
		
		if (randomNumber < difficultyLimit) {
			GameObject gameObject;
			if (rnd.Next() % 2 == 0)
			{
				gameObject = GameObject.CreatePrimitive (PrimitiveType.Cube);
			}
			else
			{
				gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			}
			gameObject.AddComponent<Rigidbody> ();
			gameObject.transform.position = new Vector3 (betweenRange(this.transform.position.x,0.5),this.transform.position.y+4.0f,this.transform.position.z);
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
