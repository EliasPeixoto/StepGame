using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MidwayTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            if (StepSpawner.stepQuantity < LevelConfig.StepQuantity) //Verifies if the number of high steps insntantiated are lower than the maximum set for the current level.
                GameObject.FindWithTag("BlockSpawner").GetComponent<EnvironmentBlockSpawner>().InstantiateBlock(this.gameObject);//If the number of high steps are lower than the maximum number, the game needs another block to instantiate the rest.
            else
                GameObject.FindWithTag("BlockSpawner").GetComponent<EnvironmentBlockSpawner>().InstantiateFinish(this.gameObject);//if the number of high steps are higher or equal to the maximum number, the game instantiate a finish block.
        }
    }
}
