using UnityEngine;

/// <summary>
/// Script de l'écran titre
/// </summary>
public class MenuScript : MonoBehaviour
{
	private GUISkin skin;
	
	void Start()
	{
		// Chargement de l'apparence
		skin = Resources.Load("GUISkin") as GUISkin;
	}
	
	void OnGUI()
	{
		const int buttonWidth = 128;
		const int buttonHeight = 60;
		
		// On applique l'apparence
		GUI.skin = skin;
		
		if (GUI.Button(
			new Rect(Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight),
			"START"
			))
		{
			Application.LoadLevel("Stage01"); // "Stage01" is the scene name
		}
	}
}