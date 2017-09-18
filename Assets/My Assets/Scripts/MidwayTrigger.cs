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
            {
                other.GetComponent<PlayerController>().enabled = false;
                LevelConfig.CouseFinished();
                SceneManager.LoadScene(0);
            }
        }
    }
}
