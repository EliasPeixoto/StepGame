using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepFall : MonoBehaviour 
{
	public float time;

	void OnCollisionEnter (Collision other)
	{
		if (other.transform.CompareTag ("Player")) 
			StartCoroutine(Timer(time));//Starts the coroutine.
	}

	IEnumerator Timer (float t)
	{
		yield return new WaitForSeconds (t);
		gameObject.GetComponent<Rigidbody> ().isKinematic = false;//Makes the step influenceable by physics therefore the step falls.
		
	}

}