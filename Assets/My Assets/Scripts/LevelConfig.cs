using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelConfig 
{

	private static int stepQuantity = 1;

	public static int StepQuantity
	{
		get{ return stepQuantity; }
		set
		{
			if (value >= 0)
			{
				stepQuantity = value;
			}
		}
	}

    public static void CouseFinished ()
    {
        stepQuantity++;
        StepSpawner.stepQuantity = 0;
    }

}
