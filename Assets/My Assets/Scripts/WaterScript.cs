using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterScript : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			StartCoroutine (Restart (other.gameObject));


		}
	}
	IEnumerator Restart (GameObject player)
	{
		yield return new WaitForSeconds(5f);
		Destroy (player);
		SceneManager.LoadScene (0);
	}
					
}
