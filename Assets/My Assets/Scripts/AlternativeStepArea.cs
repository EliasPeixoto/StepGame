using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternativeStepArea : MonoBehaviour {

    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StepMovement.isEnabled = false;
            other.GetComponent<Animator>().SetBool("CanStep", true);//Authorizes the player to step.
        }
    }
}
