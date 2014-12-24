using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;

	void Start () {
		score = PlayerPrefs.GetInt ("Score");
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(Screen.width / 2 - 40, 50, 160, 60), "You almost became a one of Winx");
		GUI.Label (new Rect(Screen.width / 2 - 40, 100, 160, 60), "Score: " + score);
		if(GUI.Button(new Rect(Screen.width / 2 - 30, 150, 120, 60), "One more time?"))
		{
			Application.LoadLevel(0);
		}
	}
}
