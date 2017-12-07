using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour 

{

	public int myHealth;
	public GameObject explosionEffect;
	public GameObject explosionEffect2;
	public GameObject[] hearts;
	public Sprite[] picture;
	private int count = 0;
	private LevelManager levelManager;
	public Text scoreboard;

	void Start(){
		levelManager = FindObjectOfType<LevelManager> ();
	
	
	}

	

	void OnCollisionEnter2D (Collision2D myCollider) {
Instantiate(explosionEffect2, myCollider.transform.position, Quaternion.identity);
			//take away health

			myHealth--;


		if (myHealth <= 0) {
			Destroy (this.gameObject);
			Instantiate(explosionEffect, gameObject.transform.position, Quaternion.identity);
			
			//if (!Player ()){
			//IncrementScore();
			//}
		}

	}
	
	void OnTriggerEnter2D (Collider2D myCollider) {
Instantiate(explosionEffect2, myCollider.transform.position, Quaternion.identity);
			//take away health

			myHealth--;

		
		if (myHealth <= 0) {
			Destroy (this.gameObject);
			Instantiate(explosionEffect, gameObject.transform.position, Quaternion.identity);
		}

	}
	
	
	
	
	private void IncrementScore(){
	
	scoreboard.text += 10;
}

}