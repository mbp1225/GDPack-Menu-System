using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButton : ButtonManager
{

	public override void Press()
	{
		aSource.PlayOneShot(pressSound);
	}
}
