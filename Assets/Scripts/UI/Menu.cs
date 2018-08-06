using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
	[SerializeField] Transform[] items;
	[SerializeField] Transform indicator;
	int currentItem = 0;

	void Start ()
	{
		StartCoroutine(ChangeItem());
	}
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow)) Navigate("up");
		if (Input.GetKeyDown(KeyCode.UpArrow)) Navigate("down");
	}

	public void Navigate (string dir)
	{
		if (dir == "up")
		{
			if (currentItem == 0) currentItem = items.Length - 1;
			else currentItem--;
			StartCoroutine(ChangeItem());
		}
		if (dir == "down")
		{
			if (currentItem == items.Length - 1) currentItem = 0;
			else currentItem++;
			StartCoroutine(ChangeItem());
		}
	}

	public void Confirm()
	{

	}

	IEnumerator ChangeItem()
	{
		yield return new WaitForSeconds(0.001f);
		indicator.position = new Vector3(indicator.position.x, items[currentItem].position.y);
	}
}
