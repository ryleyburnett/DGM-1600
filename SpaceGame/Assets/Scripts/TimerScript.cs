﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour {

	public GameObject spawn;
	public float timer;
	public float timerSave;
	
	// Use this for initialization
	void Start () {
		timerSave = timer;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0){
			timer = timerSave;
		}
		if (timer == 10){
			print ("yo");
		}
	}
	
	
}