using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {
	
	public int score;
	public Text display;
	public Text highscoreDisplay;
	public Text previousScoreDisplay;

	// Use this for initialization
	void Start () {
		score = 0;
		if (display != null){
			display.text = score.ToString();
		}
		if (highscoreDisplay != null){
			highscoreDisplay.text = GetScore ().ToString();
		}
	}
	
	public void IncrementScoreboard(int value){
		score += value;
		display.text = score.ToString();
	}
	
	public void SaveScore(){
		int oldScore = GetScore();
		if(score > oldScore)
		PlayerPrefs.SetInt ("HighScore", score);
	}
	
	public int GetScore(){
		return PlayerPrefs.GetInt ("HighScore");
	}
	
	public void OnDisable(){
		SaveScore ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
