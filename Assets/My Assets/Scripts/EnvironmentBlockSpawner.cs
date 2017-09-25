using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentBlockSpawner : MonoBehaviour
{
	public GameObject[] block = new GameObject[2]; //Variable used to store the previous block and the current block.
	public GameObject EnvironmentBlock; // Variable used to store the prefab 'Environment Block'.
    public GameObject FinishBlock; // Variable used to store the prefab 'Finish'.

	public void InstantiateBlock (GameObject obj)
	{
		if (block [0] != null) 
		{
			Destroy (block [0]); //Destroys the previous block.
		}
        block[0] = block[1]; //The current block becomes the previous block.
		block[1] = Instantiate(EnvironmentBlock,new Vector3(obj.transform.position.x,obj.transform.position.y - 5,obj.transform.position.z + 25),Quaternion.identity);//The next block becomes the current block.
			
	}

    public void InstantiateFinish (GameObject obj)
    {
        Instantiate(FinishBlock, new Vector3(obj.transform.position.x, obj.transform.position.y - 5, obj.transform.position.z + 40), Quaternion.identity);//Instantiates the finish block.
    }
}
