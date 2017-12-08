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
	
	// Use this for initialization
	void Start () {
		 
		transform.position = Random.insideUnitCircle * 5;
		
	}
	
	// Update is called once per frame
	void Update () {

		//transform.LookAt(target);
		
		//Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		//Vector3 dir = Input.mousePosition - pos;
		//float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
		//transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		
		//Vector3 targetDir = target.position - transform.position;
        //float step = speed * Time.deltaTime;
        //Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
        //Debug.DrawRay(transform.position, newDir, Color.red);
       // transform.rotation = Quaternion.LookRotation(newDir);
		
		
		//transform.right = followObj.transform.position - transform.position;
		rb2D.AddForce(transform.up * thrust);
			
	
}
	
}
