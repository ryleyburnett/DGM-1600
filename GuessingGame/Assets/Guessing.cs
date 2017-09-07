using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guessing : MonoBehaviour 
{

	private int max = 100;
	private int min = 1;
	private int guess;

	public int counter = 6;


	// Use this for initialization
	void Start () 
	{
		

		guess = Random.Range(min, max);

		print ("Welcome to Number Guesser");
		print ("Pick a Number in Your Head");

		print ("The Highest Number You Can Pick is " + max);
		print ("The Lowest Number You Can Pick is " + min);

		max = max + 1;	

		print ("Up Arrow for Higher, Down Arrow for Lower, & Enter for Equal");
		print ("Is the Number Higher or Lower Than " + guess);

	}




	// Update is called once per frame
	void Update () 
	{
		if (counter == -1) 
		{
			if (Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.DownArrow));{
				print ("You Win, I Lose...");
			
			}
		}

		else if (Input.GetKeyDown(KeyCode.UpArrow)) 
		{
			min = guess;
			guess = (max + min) / 2;	
			counter--;
			print ("Is the Number Higher or Lower Than " + guess);



		}

		else if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			max = guess;
			guess = (max + min) / 2;
			counter--;
			print ("Is the Number Higher or Lower Than " + guess);

		}
	
		if (Input.GetKeyDown (KeyCode.Return))
		{
			print ("Congrats, The Computer Has Gained Intelligence and is Now Smarter Than You. It Has Determined That Your Number is " + guess);

		}

		// When counter equals zero then player wins
		if (counter == 0) 
		{
			counter--;
			
		
			//if (Input.GetKeyDown (KeyCode.Return))
			//{
				//print ("Congrats, The Computer Has Gained Intelligence and is Now Smarter Than You. It Has Determined That Your Number is " + guess);

			//}
			//if (Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.DownArrow));
				
			//{

					//counter--;
					//print ("I Lose, You Win...");

				//}

			



		}








	}

}
