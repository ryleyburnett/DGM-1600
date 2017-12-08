using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ProjectileMeteor : MonoBehaviour {
	
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public float speed;
	public float myRandom;
	public float startingSpin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonUp("Fire1"))
		{
			myRandom = Random.Range(0.0f, 10.0f);
			
			if(myRandom <= 1 ){
			GetComponent<Rigidbody2D> ().AddTorque (Random.Range(-startingSpin,startingSpin), ForceMode2D.Impulse);
			
				
			GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
			
				//transform.position = Random.insideUnitCircle * 5;
				shot.GetComponent<Rigidbody2D>().AddForce(shotPos.right * shotForce);
			
			}
		}
			
	}
}
