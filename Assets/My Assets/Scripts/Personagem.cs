using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour {


	void FixedUpdate () 
	{
		if (Input.GetButton ("Jump")) 
		{
			GetComponent<Animator> ().SetTrigger ("Input");
			GetComponent<Animator> ().SetBool ("CanStep", false);
		}
			
	}
}
