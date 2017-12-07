using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {

	public float lifetime;
	public float Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		lifetime -= Time.deltaTime;
		if (lifetime <= 0) {
			Destroy (this.gameObject);
		}
	
	}
	
	void OnTriggerEnter2D(Collider2D other){
			
			Destroy (gameObject);
		}
	
}
