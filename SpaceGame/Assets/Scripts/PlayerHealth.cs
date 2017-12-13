using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

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
	public void LoadLevel (string name){
		SceneManager.LoadScene (name);


	}
	public void LoadNextLevel (){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);


	}
	
	

	void OnCollisionEnter2D (Collision2D myCollider) {
		Instantiate(explosionEffect2, myCollider.transform.position, Quaternion.identity);
			//take away health

			myHealth--;


		if (myHealth <= 0) {
			Destroy (this.gameObject);
			Instantiate(explosionEffect, gameObject.transform.position, Quaternion.identity);
			LoadNextLevel ();
			
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
			LoadNextLevel ();
		}

	}
	
	
	
	
	private void IncrementScore(){
	
	scoreboard.text += 10;
}

}
