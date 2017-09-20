using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (StepSpawner.stepQuantity >= LevelConfig.StepQuantity)
            {
               
            }

        }
    }
}
   
