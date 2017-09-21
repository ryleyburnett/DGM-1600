using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weiner : MonoBehaviour 
{
	public Text textbox;
	public enum States {start, injured, wearing, getout01, };
	public States myCurrentState;


	// Use this for initialization
	void Start () 
	{
		myCurrentState = States.start;





	}

	// Update is called once per frame
	void Update () 
	{
		if (myCurrentState == States.start)  { State_start (); }
		if (myCurrentState == States.injured) { State_injured ();}
		if (myCurrentState == States.wearing) { State_wearing ();}
		if (myCurrentState == States.getout01) { State_getout01 ();}


	}

	// Something Unknown
	void State_start(){ 
		textbox.text = "YOU FIND YOURSELF INSIDE OF A MASSIVE STOMACH... " +
			"\nYOU DON'T KNOW HOW OR WHY YOU'RE THERE." +
			"\nTHE STOMACH FLUID RIPPLES AS THE CREATURE MOVES..." +
			"\n " +
			"\nWHAT DO YOU DO?" +
			"\n " +
			"\n       1. CHECK TO SEE IF YOU'RE INJURED." +
			"\n       2. SEE WHAT YOU'RE WEARING." +
			"\n       3. LOOK FOR A WAY OUT.";

		if (Input.GetKeyDown (KeyCode.Keypad1)) {
			myCurrentState = States.injured;
		} 
		else if (Input.GetKeyDown (KeyCode.Keypad2)) {
			myCurrentState = States.wearing;
		}
		else if (Input.GetKeyDown (KeyCode.Keypad3)) {
			myCurrentState = States.getout01;
		}
			
	
}
	void State_injured()
	{
		textbox.text = "YOUR HEAD HURTS... " +
			"\nYOU CAN'T REMEMBER ANY OF THE EVENTS LEADING UP TO NOW. " +
			"\n " +
			"\n       0. GO BACK AND DECIDE WHAT TO DO";

		if (Input.GetKeyDown (KeyCode.Keypad0)) {
			myCurrentState = States.start;
		} 


	}

	void State_wearing()
	{
		textbox.text = "YOU SEEM TO BE WEARING SOME SORT OF SPACESUIT AND HELMET;" +
			"\nHOWEVER IT'S SOMEWHAT TORN ON THE SHOULDER. " +
			"\nTHERE'S A COMMUNICATION DEVICE ON YOUR CHEST." +
			"\n " +
			"\n       0. GO BACK AND DECIDE WHAT TO DO";

		if (Input.GetKeyDown (KeyCode.Keypad0)) {
			myCurrentState = States.start;
		} 



	}

	void State_getout01()
	{
		textbox.text = "THERE SEEMS TO BE ONLY TWO WAYS OUT:" +
			"\nBACK UP THROUGH THE ESOPHAGUS," +
			"\nOR DOWN A DEEP HOLE UNDERWATER, IN THE CENTER OF THE STOMACH." +
			"\n " +
			"\n       0. GO BACK AND DECIDE WHAT TO DO";

		if (Input.GetKeyDown (KeyCode.Keypad0)) {
			myCurrentState = States.start;
		} 

	}
}
