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
	public override void Press()
	{
		tutorial.gameObject.SetActive(true);
		tutorial.Tutorial(gameName, tutorialText, tutorialImage);
		aSource.PlayOneShot(pressSound);
	}
}
