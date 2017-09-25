using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepArea : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().canStep = true;//Authorizes the player to step.
        }
	}
}
