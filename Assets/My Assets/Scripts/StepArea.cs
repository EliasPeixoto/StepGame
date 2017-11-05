using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepArea : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
        if(other.CompareTag("Player"))
        {
            Debug.Log("Olha o player");
            other.GetComponent<Animator>().SetBool("CanStep", true);//Authorizes the player to step.
            other.GetComponent<Animator>().SetBool("Idle", true);
        }
	}
}
