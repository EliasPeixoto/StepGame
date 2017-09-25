using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelConfig 
{
    private static int increment = 1;
	private static int stepQuantity = 1;//Determines the maximum ammount of step the current level has.

	public static int StepQuantity
	{
		get{ return stepQuantity; }
		set
		{
			if (value > 0)
			{
				stepQuantity = value;
			}
		}
	}

    public static int Increment
    {
        get{ return increment; }
        set
        {
            if (value > 0)
            {
                increment = value;
            }
        }
    }          
           

    public static void CouseFinished ()
    {
        stepQuantity = stepQuantity + increment;//Increases the maximum number of steps for the next level.
        StepSpawner.stepQuantity = 0;//Resets the number of steps instantated.
    }

}
