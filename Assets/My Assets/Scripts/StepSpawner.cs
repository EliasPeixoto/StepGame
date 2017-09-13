using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSpawner : MonoBehaviour {

	public GameObject lowStep;
	public GameObject highStep;
	public GameObject coin;
	int stepCount = 0;

	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < 50; i++) 	
		{
			float chance = Random.Range (0f,1f);
			if(stepCount > 5 && chance < 0.2 && LevelConfig.StepNumber > 0)
			{
				GameObject Step = GameObject.Instantiate (highStep, new Vector3 (transform.position.x + i, transform.position.y, transform.position.z),Quaternion.identity);
				Step.transform.SetParent (transform);
				stepCount = 0;
				LevelConfig.StepNumber--;
				float coinChance = Random.Range (0f, 1f);
				if (coinChance > 0.5) {
					Instantiate (coin, new Vector3 (transform.position.x + i, transform.position.y + 0.5f, transform.position.z), Quaternion.AngleAxis(90f,Vector3.forward));
				}
			}
			else
			{
				GameObject Step = GameObject.Instantiate(lowStep,new Vector3 (transform.position.x + i, transform.position.y, transform.position.z),Quaternion.identity);
				Step.transform.SetParent (transform);
				stepCount++;
				float coinChance = Random.Range (0f, 1f);
				if (coinChance > 0.5) {
					Instantiate (coin, new Vector3 (transform.position.x + i, transform.position.y + 0.5f, transform.position.z), Quaternion.AngleAxis(90f,Vector3.forward));
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
