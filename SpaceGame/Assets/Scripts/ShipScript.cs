using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour {

	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public float speed;
    public Vector2 velocity;
    public Rigidbody2D rb2D;
	public float thrust;

	// Use this for initialization
	void Start () {
		 rb2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		{	//if (Input.GetKey(KeyCode.A))
			//{
			//	transform.position += Vector3.left * speed * Time.deltaTime;
			//}
			//if (Input.GetKey(KeyCode.D))
			//{
			//	transform.position += Vector3.right * speed * Time.deltaTime;
			//}
			//if (Input.GetKey(KeyCode.W))
			//{
			//	transform.position += Vector3.up * speed * Time.deltaTime;
			//}
			//if (Input.GetKey(KeyCode.S))
			//{
			//	transform.position += Vector3.down * speed * Time.deltaTime;
			//}
		}
		
		

		
		
		if(Input.GetButtonUp("Fire1"))
		{
			GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);
			//shot.AddForce(shotPos.forward * shotForce);
		}
	


	}
	
	void FixedUpdate () {
		if (Input.GetKey ("space"))
		{
			rb2D.AddForce(transform.up * thrust);
		}
	}


//void FixedUpdate() {
        //if (Input.GetKey(KeyCode.W))
			//{
			//	 rb2D.MovePosition(rb2D.position + velocity * speed * Time.fixedDeltaTime);
			//}
    //}

}


