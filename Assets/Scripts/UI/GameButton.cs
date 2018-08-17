using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButton : ButtonManager
{
	[Header("Game Parameters")]
	[SerializeField] string gameName;

	[SerializeField] Scene gameScene;
	[SerializeField] string tutorialText;
	[SerializeField] Texture tutorialImage;

	[Header("Tutorial Screen Reference")]
	[SerializeField] TutorialScreen tutorial;
	[SerializeField] MenuController menuController;

	public override void Press()
	{
		//tutorial.gameObject.SetActive(true);
		menuController.EnableOverlay("tutorial");
		tutorial.Tutorial(gameName, tutorialText, tutorialImage);
		aSource.PlayOneShot(pressSound);
	}
}
