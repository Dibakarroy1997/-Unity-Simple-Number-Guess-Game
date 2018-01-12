using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberGuess : MonoBehaviour {
	//Instance variables
	int max = 1001, min = 1, guess, tries = 10;
	public Text text;
	
	int NextGuess(){
		if (tries <= 0) {
			Application.LoadLevel("Win");
		}

		guess = Random.Range (min, max);

		text.text = "Is the number " + guess 
			+ "?. If no then is it higher or lower than " + guess 
			+ "? By the way, I still have " + tries + " chances left.";

		tries--;
		return(guess);
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess ();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess ();
	}

	void Start(){
		NextGuess ();
	}
}
