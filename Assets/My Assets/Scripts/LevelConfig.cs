using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelConfig 
{

	private static int stepNumber = 10;

	public static int StepNumber
	{
		get{ return stepNumber; }
		set
		{
			if (value >= 0)
			{
				stepNumber = value;
			}
		}
	}
}
