using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 1f;
	public float jumpforce = 1;
	// Use this for initialization

	void FixedUpdate () 
	{

		if (Input.GetButton ("Jump") && GetComponent<Rigidbody> ().velocity.y == 0) 
		{
			GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpforce);
		}
	}
}
