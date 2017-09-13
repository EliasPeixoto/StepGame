using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player"))
			PlayerScore.AddScore ();
		Debug.Log (PlayerScore.Score);
		Destroy (this.gameObject);
	}
}
