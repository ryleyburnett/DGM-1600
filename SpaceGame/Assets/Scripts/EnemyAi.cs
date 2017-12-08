using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour {
	public GameObject[] obj;
	public Vector2 velocity;
    public Rigidbody2D rb2D;
	public float thrust;
	public GameObject followObj;
	public Transform target;
    public float speed;
	public float myRandom;
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public float startingSpin;
	
	// Use this for initialization
	void Start () {
		 
		
		Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 dir = Input.mousePosition - pos;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		
	}
	
	// Update is called once per frame
	void Update () {

		//transform.LookAt(target);
		if(Input.GetButtonUp("Fire1"))
		{
			myRandom = Random.Range(0.0f, 10.0f);
			
			if(myRandom <= 1 ){
			
			
				
			GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
			
				//transform.position = Random.insideUnitCircle * 5;
				
			
			}
		}
	
		
		
		
		//transform.right = followObj.transform.position - transform.position;
		rb2D.AddForce(transform.up * thrust);
			
	
}
	
}
