using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour 

{

	public int myHealth;
	public GameObject explosionEffect;
	public GameObject[] hearts;
	public Sprite[] picture;
	private int count = 0;
	private LevelManager levelManager;

	void Start(){
		levelManager = FindObjectOfType<LevelManager> ();
	}

	

	void OnCollisionEnter2D (Collision2D myCollider) {

		//take away health

		myHealth--;

		//if health is < 0 destroy brick

		if (myHealth <= 0) {
			//LevelManager.brickCount--;
			//levelManager.CheckBrickCount ();
			Destroy (this.gameObject);
		}

	}


}