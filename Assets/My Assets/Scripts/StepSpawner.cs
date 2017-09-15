using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSpawner : MonoBehaviour {

	public GameObject LowStep;
	public GameObject HighStep;
	bool IsLowStep = true;

	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < 50; i++) 	
		{
			float chance = Random.Range (0f,1f);
			if(i > 5 && chance < 0.2)
			{
				IsLowStep = !IsLowStep;
			}
			if (IsLowStep) 
			{
				GameObject Step = GameObject.Instantiate(LowStep,new Vector3 (transform.position.x, transform.position.y, transform.position.z + i),Quaternion.identity);
				Step.transform.SetParent (transform);
			} else 
			{
				GameObject Step = GameObject.Instantiate (HighStep, new Vector3 (transform.position.x, transform.position.y, transform.position.z + i),Quaternion.identity);
				Step.transform.SetParent (transform);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
