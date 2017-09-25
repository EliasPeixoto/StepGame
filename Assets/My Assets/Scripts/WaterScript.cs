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
        Destroy(player);//Kills the character.
		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene (0);
	}
					
}
