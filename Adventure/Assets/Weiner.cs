using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weiner : MonoBehaviour 
{
	public Text textbox;
	public enum States {start, injured, wearing, getout01, stranger, checkman01, disregard, wake, climb01, swim01, };
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
		if (myCurrentState == States.stranger) { State_stranger ();}
		if (myCurrentState == States.checkman01) { State_checkman01 ();}
		if (myCurrentState == States.disregard) { State_disregard ();}
		if (myCurrentState == States.wake) { State_wake ();}
		if (myCurrentState == States.climb01) { State_climb01 ();}
		if (myCurrentState == States.swim01) { State_swim01 ();}


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
			"\n " +
			"\n " +
			"\n " +
			"\n       0. GO BACK AND DECIDE WHAT TO DO" +
			"\n " +
			"\n ";

		if (Input.GetKeyDown (KeyCode.Keypad0)) {
			myCurrentState = States.start;
		} 


	}

	void State_wearing()
	{
		textbox.text = "YOU SEEM TO BE WEARING SOME SORT OF SPACESUIT AND HELMET;" +
			"\nHOWEVER IT'S SOMEWHAT TORN ON THE SHOULDER. " +
			"\n " +
			"\nTHERE'S A COMMUNICATION DEVICE ON YOUR CHEST." +
			"\n " +
			"\n " +
			"\n       0. GO BACK AND DECIDE WHAT TO DO" +
			"\n " +
			"\n ";

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
			"\nYOU HEAR A NOISE COMING FROM ABOVE YOU....." +
			"\n " +
			"\n       Enter. NEXT" +
			"\n " +
			"\n "; 

		if (Input.GetKeyDown (KeyCode.KeypadEnter)) {
			myCurrentState = States.stranger;
		} 

	}

	void State_stranger()
	{
		textbox.text = "SUDDENLY, A MAN FALLS FROM THE DARKNESS ABOVE" +
			"\n AND SPLASHES INTO THE STOMACH FLUID WITH YOU." +
		"\n " +
		"\n " +
		"\n " +
		"\n       1. SEE IF HE'S OKAY." +
		"\n       2. DISREGARD THAT A MAN JUST FELL " +
		"\n          INTO YOUR ACIDIC HOT TUB" +
		"\n          AND INSTEAD, ATTEMPT TO CLIMB OR SWIM OUT."; 

		if (Input.GetKeyDown (KeyCode.Keypad1)) {
			myCurrentState = States.checkman01;
		} else if (Input.GetKeyDown (KeyCode.Keypad2)) {
			myCurrentState = States.disregard;
		}
	}

	void State_checkman01()
	{
		textbox.text = "YOU FLIP THE MAN OVER, HE'S KNOCKED OUT COLD." +
		"\n " +
		"\n        Enter. WAKE HIM UP.";

		if (Input.GetKeyDown (KeyCode.KeypadEnter)) {
			myCurrentState = States.wake;
		} 

	}

	void State_disregard()
	{
		textbox.text = "YOU DECIDE TO DISREGARD THE MAN WHO JUST FELL IN." +
			"\nHE'S PROBABLY DEAD BECAUSE HE HASN'T MOVED." +
			"\n " +
			"\nYOU CAN EITHER ATTEMPT TO CLIMB UP THROUGH THE ESOPHAGUS" +
			"\nOR SWIM THROUGH THE DEEP HOLE INTO THE INTESTINES." +
			"\n" +
			"\n        1. CLIMB" +
			"\n        2. SWIM" +
			"\n        3. SEE IF THE MAN IS DEAD";

		if (Input.GetKeyDown (KeyCode.Keypad1)) {
			myCurrentState = States.climb01;
		} 
		else if (Input.GetKey (KeyCode.Keypad2)) {
			myCurrentState = States.swim01;
		} 
		else if (Input.GetKeyDown (KeyCode.Keypad3)) {
			myCurrentState = States.checkman01;
		} 
	}

	void State_climb01()
	{
		textbox.text = "THE LINING OF THE STOMACH IS TOO SLIPPERY," +
		"\nTHERES NO WAY TO CLIMB OUT." +
		"\n" +
		"\n" +
		"\n" +
		"\n" +
		"\n       0. GO BACK AND DECIDE WHAT TO DO." +
		"\n" +
		"\n";

		if (Input.GetKeyDown (KeyCode.Keypad0)) {
			myCurrentState = States.disregard;
		} 
	}

	void State_swim01()
	{
		textbox.text = "IT'S TOO DEEP TO SWIM WITH ONE BREATH," +
		"\nTHE DEEPER YOU SWIM, THE MORE YOUR SUIT FILLS WITH LIQUID" +
		"\nMAKING IT MUCH HARDER TO RETURN TO THE SURFACE FOR AIR." +
		"\n" +
		"\n" +
		"\n" +
		"\n       0. GO BACK AND DECIDE WHAT TO DO." +
		"\n" +
		"\n";

		if (Input.GetKeyDown (KeyCode.Keypad0)) {
			myCurrentState = States.disregard;
		} 


	}

	void State_wake()
	{
		textbox.text = "THE MAN WAKES UP WITH A BLOOD-CURDLING SCREAM" +
			"\nHE IS HYPERVENTALATING BUT SOON CALMS DOWN." +
			"\n" +
			"\n" +
			"\n" +
			"\n" +
			"\nHE ASKS YOUR NAME..." +
			"\n" +
			"\n";
	}








}

