﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEX : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy(gameObject, GetComponent<ParticleSystem>().duration);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
