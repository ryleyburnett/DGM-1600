using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public static int brickCount;
	public float timer;
	private float timerSave;
	
	// Use this for initialization
	void Start () {
		timerSave = timer;
		brickCount = FindObjectsOfType<health> ().Length;
		print (brickCount);
	}
	
	
	public void LoadLevel (string name){
		SceneManager.LoadScene (name);


	}

	public void ExitGame (){
		print ("Tried to Exit");
		Application.Quit ();
	}

	public void LoadNextLevel (){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);


	}

	public void CheckBrickCount () {
		if(brickCount <= 0) {
			LoadNextLevel ();
	}
}
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0){
			timer =timerSave;
		}
	}
	
	
}
