using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepFall : MonoBehaviour 
{
	public float time;

	void OnCollisionEnter (Collision other)
	{
		if (other.transform.CompareTag ("Player")) 
			StartCoroutine(Timer(time));
	}

	IEnumerator Timer (float t)
	{
		yield return new WaitForSeconds (t);
		gameObject.GetComponent<Rigidbody> ().isKinematic = false;
		
	}

}