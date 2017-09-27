using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepMovement : MonoBehaviour {

    public float speed = 0.1f;
    public static bool isEnabled = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        if (isEnabled)
            gameObject.transform.Translate (Vector3.back * speed);	
	}
}
