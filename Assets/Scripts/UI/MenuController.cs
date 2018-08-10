using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour
{
	[SerializeField] EventSystem eventSystem;

	[System.Serializable]
	public struct Menu
	{
		public Transform menuTransform;
		public Transform firstButton;
	}

	[SerializeField] Menu currentMenu;
	[SerializeField] Menu currentOverlay;

	[SerializeField] Menu mainMenu, medleyMenu, freeplayMenu;

	void Start ()
	{
		
	}
	
	void Update ()
	{
		
	}
}
