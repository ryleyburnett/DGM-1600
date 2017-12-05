using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour {
public GameObject[] obj;
public Transform target;
	public Vector2 velocity;
    public Rigidbody2D rb2D;
	public float thrust;
	// Use this for initialization
	void Start () {
		 
		transform.position = Random.insideUnitCircle * 5;
	}
	
	// Update is called once per frame
	void Update () {

		//transform.LookAt(target);
		
		Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 dir = Input.mousePosition - pos;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			
		rb2D.AddForce(transform.up * thrust);
			
	
}
	
}
