using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentBlockSpawner : MonoBehaviour
{
	public GameObject[] block = new GameObject[2];
	public GameObject EnvironmentBlock;

	public void InstantiateBlock (GameObject obj)
	{
		if (block [0] != null) 
		{
			Destroy (block [0]);
		}
		block[0] = block[1];
		block[1] = Instantiate(EnvironmentBlock,new Vector3(obj.transform.position.x,obj.transform.position.y - 5,obj.transform.position.z + 25),Quaternion.identity);
			
	}
}
