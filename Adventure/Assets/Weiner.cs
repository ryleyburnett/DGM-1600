using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weiner : MonoBehaviour 
{
	public Text textbox;
	public enum States {start, injured, wearing, getout01, stranger, stranger01, checkman01, disregard, wake, climb01, 
		swim01, nametext, deadman, eatenalive, communication, ter, david, shareair, steal, swim02, shareair01, patch, };
	public States myCurrentState;

	public bool commdev = false;


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
		if (myCurrentState == States.nametext) { State_nametext ();}
		if (myCurrentState == States.deadman) { State_deadman ();}
		if (myCurrentState == States.eatenalive) { State_eatenalive ();}
		if (myCurrentState == States.stranger01) { State_stranger01 ();}
		if (myCurrentState == States.communication) { State_communication ();}
		if (myCurrentState == States.ter) { State_ter ();}
		if (myCurrentState == States.david) { State_david ();}
		if (myCurrentState == States.shareair) { State_shareair ();}
		if (myCurrentState == States.steal) { State_steal ();}
		if (myCurrentState == States.shareair01) { State_shareair01 ();}
		if (myCurrentState == States.patch) { State_patch ();}
		if (myCurrentState == States.swim02) { State_swim02 ();}

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

		if (Input.GetKeyUp (KeyCode.Keypad1)) {
			myCurrentState = States.injured;
		} 
		else if (Input.GetKeyUp (KeyCode.Keypad2)) {
			myCurrentState = States.wearing;
		}
		else if (Input.GetKeyUp (KeyCode.Keypad3)) {
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

		if (Input.GetKeyUp (KeyCode.Keypad0)) {
			myCurrentState = States.start;
		} 


	}

	void State_wearing()
	{
		textbox.text = "YOU SEEM TO BE WEARING SOME SORT OF SPACESUIT AND HELMET;" +
			"\nHOWEVER IT'S SOMEWHAT TORN ON THE SHOULDER. " +
			"\n " +
			"\nTHERE'S A COMMUNICATION DEVICE ON YOUR CHEST." +
			"\nYOU MIGHT BE ABLE TO USE IT LATER..." +
			"\n " +
			"\n       0. GO BACK AND DECIDE WHAT TO DO" +
			"\n " +
			"\n ";

		if (Input.GetKeyUp (KeyCode.Keypad0)) {
			commdev = true;
			myCurrentState = States.start;
		} 



	}

	void State_getout01()
	{
		textbox.text = "THERE SEEMS TO BE ONLY TWO WAYS OUT:" +
			"\nBACK UP THROUGH THE ESOPHAGUS," +
			"\nOR DEEP DOWN A HOLE UNDERWATER, IN THE CENTER OF THE STOMACH." +
			"\n " +
			"\nYOU HEAR A NOISE COMING FROM ABOVE YOU....." +
			"\n " +
			"\n       Enter. NEXT" +
			"\n " +
			"\n "; 

		if (Input.GetKeyUp (KeyCode.KeypadEnter))  {
				myCurrentState = States.stranger;
			}
		 

	}

	void State_stranger()
	{
		if (commdev == true) {
			textbox.text = "SUDDENLY, A MAN FALLS FROM THE DARKNESS ABOVE" +
			"\nAND SPLASHES INTO THE STOMACH FLUID WITH YOU." +
			"\n " +
			"\n " +
			"\n       1. SEE IF HE'S OKAY." +
			"\n       2. DISREGARD THAT A MAN JUST FELL " +
			"\n          INTO YOUR ACIDIC HOT TUB" +
			"\n          AND INSTEAD, ATTEMPT TO CLIMB OR SWIM OUT." +
			"\n       3. ATTEMPT TO USE YOUR COMMUNICATION DEVICE.";
		} else 
		{
			textbox.text = "SUDDENLY, A MAN FALLS FROM THE DARKNESS ABOVE" +
			"\nAND SPLASHES INTO THE STOMACH FLUID WITH YOU." +
			"\n " +
			"\n " +
			"\n " +
			"\n       1. SEE IF HE'S OKAY." +
			"\n       2. DISREGARD THAT A MAN JUST FELL " +
			"\n          INTO YOUR ACIDIC HOT TUB" +
			"\n          AND INSTEAD, ATTEMPT TO CLIMB OR SWIM OUT."; 

		}

		if (Input.GetKeyUp (KeyCode.Keypad1)) {
			myCurrentState = States.checkman01;
		} else if (Input.GetKeyUp (KeyCode.Keypad2)) {
			myCurrentState = States.disregard;
		} else if (Input.GetKeyUp (KeyCode.Keypad3)) {
			myCurrentState = States.communication;
		}


	}

	void State_stranger01()
	{
		
			textbox.text = "SUDDENLY, A MAN FALLS FROM THE DARKNESS ABOVE" +
			"\nAND SPLASHES INTO THE STOMACH FLUID WITH YOU." +
			"\n " +
			"\n " +
			"\n       1. SEE IF HE'S OKAY." +
			"\n       2. DISREGARD THAT A MAN JUST FELL " +
			"\n          INTO YOUR ACIDIC HOT TUB" +
			"\n          AND INSTEAD, ATTEMPT TO CLIMB OR SWIM OUT." +
			"\n       3. ATTEMPT TO USE YOUR COMMUNICATION DEVICE.";
		

			if (Input.GetKeyUp (KeyCode.Keypad1)) {
				myCurrentState = States.checkman01;
			} else if (Input.GetKeyUp (KeyCode.Keypad2)) {
				myCurrentState = States.disregard;
			} else if (Input.GetKeyUp (KeyCode.Keypad3)) {
				myCurrentState = States.communication;
			}

	}


	void State_checkman01()
	{
		//if (Random.value < 0.05) {
			//myCurrentState = States.deadman;
		//} else if (Random.value > 0.05) {

			textbox.text = "YOU FLIP THE MAN OVER, HE'S KNOCKED OUT COLD." +
			"\n" +
			"\n" +
			"\n" +
			"\n" +
			"\n " +
			"\n        Enter. WAKE HIM UP." +
			"\n" +
			"\n";
		

		if (Input.GetKeyUp (KeyCode.KeypadEnter)) {
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
			"\n        4. CLIMB" +
			"\n        5. SWIM" +
			"\n        6. SEE IF THE MAN IS DEAD";

		if (Input.GetKeyUp (KeyCode.Keypad4)) {
			myCurrentState = States.climb01;
		} 
		else if (Input.GetKeyUp (KeyCode.Keypad5)) {
			myCurrentState = States.swim01;
		} 
		else if (Input.GetKeyUp (KeyCode.Keypad6)) {
			myCurrentState = States.deadman;
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

		if (Input.GetKeyUp (KeyCode.Keypad0)) {
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

		if (Input.GetKeyUp (KeyCode.Keypad0)) {
			myCurrentState = States.disregard;
		} 


	}

	void State_wake()
	{
		textbox.text = "THE MAN WAKES UP WITH A BLOOD-CURDLING SCREAM" +
		"\nHE IS HYPERVENTALATING BUT SOON CALMS DOWN." +
		"\n" +
		"\n" +
		"\nYOU NOTICE THAT HE HIS SUIT ISN'T DAMAGED" +
		"\n" +
		"\n       0. ASK WHAT'S GOING ON." +
		"\n" +
		"\n";

		if (Input.GetKeyUp (KeyCode.Keypad0)) {
			myCurrentState = States.nametext;
		}
	}
			
	void State_nametext()
	{
		textbox.text = "THE MAN SAYS HIS NAME IS DAVID." +
			"\nHE WAS A MEMBER OF A MINING CREW ON A NEWLY DISCOVERED MOON. " +
			"\n" +
			"\nTHEY WERE MINING DEEP IN A CAVE, IN SEARCH OF A RARE FUEL." +
			"\nHE REMEMBERS HEARING A RUMBLE AND SUDDENLY HE APPEARED HERE." +
			"\n" +
			"\n       Enter. NEXT" +
			"\n" +
			"\n";
		if (Input.GetKeyUp (KeyCode.KeypadEnter)) {
			myCurrentState = States.ter;
		}

			
		

	}

	void State_deadman()
	{
		textbox.text = "THE MAN IS BLEEDING OUT" +
		"\n" +
		"\nHIS BLOOD ATTRACTS WHITE, FLESH-EATING WORMS..." +
		"\nTHEY SWIM OVER & STRIP HIM OF ALL SKIN AND MEAT..." +
		"\nONLY HIS SKELETON IS LEFT." +
		"\n" +
		"\n       Enter. NEXT" +
		"\n" +
		"\n";

		if (Input.GetKeyUp (KeyCode.KeypadEnter)) {
			myCurrentState = States.eatenalive;
		}

	}

	void State_eatenalive()
	{
		textbox.text = "THE  FLESH-EATING WORMS SWIM INTO THE TORN SLEEVE IN YOUR SUIT. " +
			"\nYOU ARE EATEN ALIVE." +
			"\n" +
			"\nYOU LOSE." +
			"\n" +
			"\nPLAY AGAIN?" +
			"\n" +
			"\n       1. YES" +
			"\n       2. NO";

		if (Input.GetKeyUp (KeyCode.Keypad1)) {
			myCurrentState = States.start;
		} else if (Input.GetKeyUp (KeyCode.Keypad2)) {
			Application.Quit ();
		}

	}

	void State_communication()
	{
		textbox.text = "YOU HEAR A MAN'S VOICE COMING THROUGH..." +
		"\nHE'S ASKING IF THERE ARE ANY SURVIVORS." +
		"\nTHE BUTTON ENABLING YOU TO TALK BACK IS BUSTED..." +
		"\n" +
		"\nTHERE'S STILL HOPE..." +
		"\n" +
		"\n       Enter. Next" +
		"\n" +
		"\n";
		commdev = false;

		if (Input.GetKeyUp (KeyCode.KeypadEnter)) {
			myCurrentState = States.stranger;
		}

	}

																						void State_ter()
	{
		textbox.text = "DAVID SAYS THAT YOU NEED TO FIND A WAY OUT" +
			"\n'I HAVE AN IDEA, WE CAN TRY...'" +
			"\n[YOU STOP LISTENING BECAUSE YOU'RE A TERRIBLE PERSON.]" +
			"\nYOU NOTICE THAT HE HAS A FULL AIR TANK" +
			"\nHE ALSO HAS A PLASMA BLASTER ON HIS BELT..." +
			"\n" +
			"\n   1. GO WITH DAVID'S IDEA." +
			"\n   2. SEE IF THERE'S ANY WAY TO SHARE AIR." +
			"\n   3. TRY TO STEAL HIS BLASTER.";
	
		if (Input.GetKeyUp (KeyCode.Keypad1)) {
			myCurrentState = States.david;
		} else if (Input.GetKeyUp (KeyCode.Keypad2)) {
			myCurrentState = States.shareair;
		} else if (Input.GetKeyUp (KeyCode.Keypad3)) {
			myCurrentState = States.steal;
		}
	
	}

	void State_david()
	{
		textbox.text = "'WELL, LETS TRY TO SWIM THROUGH THAT HOLE." +
			"\n" +
			"\n" +
			"\n" +
			"\n" +
			"\n" +
			"\n   4. SAY, 'MY SUIT HAS A TEAR, MY AIR SUPPLY IS RUNNING OUT.'" +
			"\n   5. TRY TO SWIM WITH DAVID" +
			"\n";
		if (Input.GetKeyUp (KeyCode.Keypad4)) {
			myCurrentState = States.patch;
		} else if (Input.GetKeyUp (KeyCode.Keypad5)) {
			myCurrentState = States.swim02;
		}
	}

	void State_patch()
	{


	}
	void State_swim02()
	{
		textbox.text = "YOU TRY TO SWIM BUT SINK INSTEAD." +
			"\nYOUR SUIT FILLS. YOU ARE DRUG DOWN." +
			"\nYOU BREATH IN BILE. YOUR LUNGS DISSOLVE." +
			"\n" +
			"\nYOU LOSE. PLAY AGAIN?" +
			"\n" +
			"\n   Enter. YES" +
			"\n   0. NO" +
			"\n";
		if (Input.GetKeyUp (KeyCode.KeypadEnter)) {
			myCurrentState = States.start;
		} else if (Input.GetKeyUp (KeyCode.Keypad0)) {
			Application.Quit ();
		}
	}

	void State_shareair()
	{
		textbox.text = "'THE VALVES WERE DESIGNED TO ONLY LET AIR INTO" +
			"\nONE SUIT. IF WE TRIED TO SHARE AIR, WE WOULD BOTH DIE.'" +
			"\n" +
			"\n" +
			"\n" +
			"\n" +
			"\n   4. GO BACK" +
			"\n   5. TRY TO SHARE AIR." +
			"\n";
		if (Input.GetKeyUp (KeyCode.Keypad4)) {
			myCurrentState = States.ter;
		} else if (Input.GetKeyUp (KeyCode.Keypad5)) {
			myCurrentState = States.shareair01;
		}
	}

	void State_steal()
	{
		textbox.text = "YOU GO TO STEAL HIS BLASTER." +
			"\nHE NOTICES AND SHOOTS YOU DEAD." +
			"\n" +
			"\n" +
			"\nYOU LOSE. PLAY AGAIN?" +
			"\n" +
			"\n   Enter. YES" +
			"\n   0. NO" +
			"\n";
		if (Input.GetKeyUp (KeyCode.KeypadEnter)) {
			myCurrentState = States.start;
		} else if (Input.GetKeyUp (KeyCode.Keypad0)) {
			Application.Quit ();
		}

	}

	void State_shareair01()
	{
		textbox.text = "YOU TRY TO SHARE AIR." +
			"\nTHIS DEPRESSURIZES BOTH SUITS INSTANTLY." +
			"\n" +
			"\n" +
			"\nYOU LOSE. PLAY AGAIN?" +
			"\n" +
			"\n   Enter. YES" +
			"\n   0. NO" +
			"\n";
		if (Input.GetKeyUp (KeyCode.KeypadEnter)) {
			myCurrentState = States.start;
		} else if (Input.GetKeyUp (KeyCode.Keypad0)) {
			Application.Quit ();
		}
	}
}

