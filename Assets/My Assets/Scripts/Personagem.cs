using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour {

	public float speed = 1;
	public float jumpforce = 1;

   

	void FixedUpdate () 
	{
		

		if (Input.GetButton ("Jump") && GetComponent<Rigidbody> ().velocity.y == 0) {
			GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpforce);
			GetComponent<Animator> ().SetTrigger ("Input");
			GetComponent<Animator> ().SetBool ("CanStep", false);
		} else 
		{
            if (GetComponent<Rigidbody>().velocity.y <= 0 && !GetComponent<Animator>().GetBool("CanStep"))
			gameObject.transform.Translate (Vector3.forward * speed);
		}
			
	}
}
