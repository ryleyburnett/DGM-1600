﻿using UnityEngine;
using System.Collections;

public class CompletePlayerController : MonoBehaviour {

	public float speed;             //Floating point variable to store the player's movement speed.

	private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
	public ParticleSystem Particles;


	// Use this for initialization
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();
		
		//print ( GetComponent<Health>().GetHealth() );
		
	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void Update (){

		if (Input.GetKey (KeyCode.Space))
			Particles.Emit (1);
		
	
	//Face Mouse
		Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 dir = Input.mousePosition - pos;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	
	}

}