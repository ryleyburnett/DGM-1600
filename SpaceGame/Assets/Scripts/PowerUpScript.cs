using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour {

	public enum Type {fancyFeast, superSpeedyBoy, lazersInYourEyes};
	public Type mypowerupType;
	public Sprite[] images;

	// Use this for initialization
	void Start () {
		switch (mypowerupType) {
		case Type.fancyFeast:
			gameObject.GetComponent<SpriteRenderer>().sprite = images [0];
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("Suck my Punk");
		//other.GetComponent<PlayerControllers> ().thrusterForce *= 2;
		Destroy (this.gameObject);
	}



}
