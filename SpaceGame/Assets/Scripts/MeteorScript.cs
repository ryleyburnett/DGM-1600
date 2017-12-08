using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour {

	public float startingSpin;
	public float thrust;
	public Rigidbody2D rb2D;
	public GameObject player;
	
	


	// Use this for initialization
	void Start () {
		
		transform.position = Random.insideUnitCircle * 5;
		transform.right = player.transform.position - transform.position;
		rb2D.AddRelativeForce(transform.up * thrust);
		
		
		GetComponent<Rigidbody2D> ().AddTorque (Random.Range(-startingSpin,startingSpin), ForceMode2D.Impulse);
		
	}
	
	// Update is called once per frame
	void Update () {

			

	}
}
