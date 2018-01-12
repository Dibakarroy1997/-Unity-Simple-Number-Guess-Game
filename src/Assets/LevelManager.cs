using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	//Load a level
	public void LoadLevel(string name){
		Debug.Log ("Loading Level " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quiting game.");
		//UnityEditor.EditorApplication.isPlaying = false;
		Application.Quit ();
	}
}
