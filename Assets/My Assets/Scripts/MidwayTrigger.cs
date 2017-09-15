using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidwayTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.FindWithTag("BlockSpawner").GetComponent<EnvironmentBlockSpawner>().InstantiateBlock(this.gameObject);
        }
    }
}
