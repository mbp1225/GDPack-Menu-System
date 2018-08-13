using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour
{
	[Header("References")]
	
	[SerializeField] EventSystem eventSystem;

	[System.Serializable]
	private struct Menu
	{
		public Transform menuTransform;
		public GameObject firstButton;
		public string previousMenu;
	}
	
	[System.Serializable]
	private struct Overlay
	{
		public Transform overlayTransform;
		public GameObject firstButton;
	}

	[SerializeField] Menu currentMenu;
	[SerializeField] Menu currentOverlay;

	[Header("Menus")] [SerializeField] private Menu startUpMenu;
	[SerializeField] private Menu mainMenu;
	[SerializeField] private Menu medleyMenu;
	[SerializeField] Menu freeplayMenu;

	[Space(10)] [Header("Overlays")]
	
	[SerializeField] private Overlay controllerOverlay;
	[SerializeField] private Overlay confirmOverlay;
	[SerializeField] private Overlay medleyOverlay;
	[SerializeField] private Overlay tutorialOverlay;
	
	private bool hasActiveOverlay = false;
	
	

	void Start ()
	{
		SwitchMenu("startup");
	}
	
	void Update ()
	{
		if (Input.GetButtonDown("Cancel") && !hasActiveOverlay)
		{
			SwitchMenu(currentMenu.previousMenu);
		}
		if (Input.GetButtonDown("Cancel") && hasActiveOverlay)
		{
			currentOverlay.menuTransform.gameObject.SetActive(false);
		}
	}

	public void toggleOverlay(string overlay)
	{
		
	}

	public void SwitchMenu(string menu)
	{
		switch (menu)
		{
			case "startup":
				currentMenu.menuTransform.gameObject.SetActive(false);
				currentMenu = startUpMenu;
				currentMenu.menuTransform.gameObject.SetActive(true);
				eventSystem.SetSelectedGameObject(currentMenu.firstButton);
				break;
			case "main":
				currentMenu.menuTransform.gameObject.SetActive(false);
				currentMenu = mainMenu;
				currentMenu.menuTransform.gameObject.SetActive(true);
				eventSystem.SetSelectedGameObject(currentMenu.firstButton);
				break;
			case "medley":
				currentMenu.menuTransform.gameObject.SetActive(false);
				currentMenu = medleyMenu;
				currentMenu.menuTransform.gameObject.SetActive(true);
				eventSystem.SetSelectedGameObject(currentMenu.firstButton);
				break;
			case "freeplay":
				currentMenu.menuTransform.gameObject.SetActive(false);
				currentMenu = freeplayMenu;
				currentMenu.menuTransform.gameObject.SetActive(true);
				eventSystem.SetSelectedGameObject(currentMenu.firstButton);
				break;
		}
	}

	public void EnableOverlay(string overlay)
	{
		
	}

	void DisableOverlay()
	{
		currentOverlay.menuTransform.gameObject.SetActive(false);
	}
}
