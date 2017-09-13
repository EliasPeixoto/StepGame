using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 1f;
	public float jumpforce = 1;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		gameObject.transform.Translate (Vector3.back * speed * h);
		gameObject.transform.Translate (Vector3.right * speed * v);

		if (Input.GetButton("Jump") && GetComponent<Rigidbody>().velocity.y == 0)
			GetComponent<Rigidbody>().AddForce(Vector3.up * jumpforce);
	}
}
