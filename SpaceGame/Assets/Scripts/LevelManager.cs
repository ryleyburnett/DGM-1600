using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	
	public float timer;
	private float timerSave;
	
	// Use this for initialization
	void Start () {
		timerSave = timer;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0){
			timer =timerSave;
		}
	}
	
	
}
