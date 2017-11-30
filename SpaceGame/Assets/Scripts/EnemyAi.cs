using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour {
public GameObject[] obj;
     public float spawnMin = 1f; //spawn aleatoriamente entre 1s
     public float spawnMax = 2f; //e 2s
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Spawn()
     {
         Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
         Invoke("Spawn", Random.Range(spawnMin, spawnMax));
     }
}
