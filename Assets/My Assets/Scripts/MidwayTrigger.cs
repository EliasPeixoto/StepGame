using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MidwayTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            if (StepSpawner.stepQuantity < LevelConfig.StepQuantity)
                GameObject.FindWithTag("BlockSpawner").GetComponent<EnvironmentBlockSpawner>().InstantiateBlock(this.gameObject);
            else
                GameObject.FindWithTag("BlockSpawner").GetComponent<EnvironmentBlockSpawner>().InstantiateFinish(this.gameObject);
            Debug.Log(StepSpawner.stepQuantity + " " + LevelConfig.StepQuantity);   
        }
    }
}
