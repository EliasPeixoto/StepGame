using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSpawner : MonoBehaviour {

	public GameObject LowStep;
	public GameObject HighStep;
    public GameObject Coin;

	bool IsLowStep = true; // Determines whether the high step or the low step is instantiated.
    int lowStepCount = 0; // Count the number of low steps to prevent a high quantity of high steps in small distances.
    public static int stepQuantity = 0; // Count the number of high steps instantiated in the course.

	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < 50; i++) 	
		{
			float chance = Random.Range (0f,1f); // Chance to instantiate the high step.
            if (lowStepCount >= 5 && chance < 0.2)
            {
                IsLowStep = false;
                lowStepCount = 0;
            }
            else
            {
                IsLowStep = true;
            }
            if (IsLowStep || stepQuantity >= LevelConfig.StepQuantity) 
			{
				GameObject Step = GameObject.Instantiate(LowStep,new Vector3 (transform.position.x, transform.position.y, transform.position.z + i),Quaternion.identity);
				Step.transform.SetParent (transform);
                lowStepCount++;
			} else 
			{
                if (stepQuantity < LevelConfig.StepQuantity)
                {
                    GameObject Step = GameObject.Instantiate(HighStep, new Vector3(transform.position.x, transform.position.y, transform.position.z + i), Quaternion.identity);
                    Step.transform.SetParent(transform);
                    stepQuantity++;
                }
			}
            float coinChance = Random.Range(0f, 1f);
            if (coinChance <= 0.35f)
                Instantiate(Coin, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z + i), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
