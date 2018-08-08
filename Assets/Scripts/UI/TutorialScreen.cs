using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialScreen : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI title;
	[SerializeField] TextMeshProUGUI text;
	[SerializeField] RawImage image;

	public void Tutorial(string gameTitle, string tutorialText, Texture gameImage)
	{
		title.text = gameTitle;
		text.text = tutorialText;
		image.texture = gameImage;
	}
}
