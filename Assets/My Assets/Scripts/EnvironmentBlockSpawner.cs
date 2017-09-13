using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentBlockSpawner : MonoBehaviour {

	public GameObject EnvironmentBlock;

	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
			Instantiate(EnvironmentBlock,new Vector3(transform.position.x,transform.position.y - 5,transform.position.z + 25),Quaternion.identity);
		
	}
}
