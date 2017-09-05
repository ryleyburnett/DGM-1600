using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guessing : MonoBehaviour 
{

	int max = 100;
	int min = 1;
	int guess = 50;


	// Use this for initialization
	void Start () 
	{
		



		print ("Welcome to Number Guesser");
		print ("Pick a Number in Your Head");

		print ("The Highest Number You Can Pick is " + max);
		print ("The Lowest Number You Can Pick is " + min);

		max = max + 1;	

		print ("Is the Number Higher or Lower Than " + guess);
		print ("Up Arrow for Higher, Down Arrow for Lower, & Enter for Equal");


	}




	// Update is called once per frame
	void Update () 
	{


		if (Input.GetKeyDown(KeyCode.UpArrow)) 
		{
			min = guess;
			guess = (max + min) / 2;				
			print ("Is the Number Higher or Lower Than " + guess);

		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			max = guess;
			guess = (max + min) / 2;				
			print ("Is the Number Higher or Lower Than " + guess);

		}
		if (Input.GetKeyDown (KeyCode.Return))
		{
			print ("Your Number is " + guess);

		}



	}

}
