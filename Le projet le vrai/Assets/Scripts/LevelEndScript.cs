using UnityEngine;
using System.Collections;

public class LevelEndScript : MonoBehaviour {

	void OnGUI()
	{
		const int buttonWidth = 120;
		const int buttonHeight = 60;
		string nextLevel = "Stage01";
		if (Application.loadedLevelName == "Stage01")
			nextLevel = "Stage02";
		
		if (
			GUI.Button(
			// Centré en x, 1/3 en y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(1 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Next Level !"
			)
			)
		{
			// Recharge le niveau
			Application.LoadLevel(nextLevel);
		}
		
		if (
			GUI.Button(
			// Centré en x, 2/3 en y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Back to menu"
			)
			)
		{
			// Retourne au menu
			Application.LoadLevel("Menu");
		}
	}
}
