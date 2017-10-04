﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternativeStepSpawner : MonoBehaviour {

    public GameObject Coin;
    public GameObject LowStep;
    public GameObject HighStep;
    public GameObject AlternativeFinish;
    public bool IsSpawner2 = true;

    bool IsLowStep = true;
    int lowStepCount = 0;
    public static bool doneSpawning = false;

    public static int stepQuantity = 0; // Count the number of high steps instantiated in the course.
    public int distance = 50;

    // Use this for initialization
    void Start () 
    {
        if(!IsSpawner2)
           AlternativeStepSpawner1();
    }


    void OnTriggerExit (Collider other)
    {
        AlternativeStepSpawner2(other);
    }
    void AlternativeStepSpawner1()
    {
        doneSpawning = false;
        StepMovement.isEnabled = true;
        Debug.Log(stepQuantity + " " + LevelConfig.StepQuantity);
        for (int i = 0; i < distance; i++)  
        {
            float chance = Random.Range (0f,1f); // Chance to instantiate the high step.
            if (lowStepCount >= 5 && chance < 0.2)//It must have at least 5 low steps instantiated in order to instnatiate a high step.
            {
                IsLowStep = false;
                lowStepCount = 0;
            }
            else
            {
                IsLowStep = true;
            }

            GameObject Step = null;

            if (IsLowStep && stepQuantity < LevelConfig.StepQuantity)//If isLowStep is true or all the high steps were already instantiated, instantiate low steps. 
            {
                Step = GameObject.Instantiate(LowStep,new Vector3 (transform.position.x, transform.position.y, transform.position.z + i),Quaternion.identity);
                Step.transform.SetParent (transform);
                lowStepCount++;
            } else 
            {
                if (stepQuantity < LevelConfig.StepQuantity)//if the number of high steps are still lower than the maximum set for this level.
                {
                    Step = GameObject.Instantiate(HighStep, new Vector3(transform.position.x, transform.position.y, transform.position.z + i), Quaternion.identity);
                    Step.transform.SetParent(transform);
                    stepQuantity++;
                }
                else
                {
                    doneSpawning = true;
                    Instantiate(AlternativeFinish,new Vector3(transform.position.x, transform.position.y, transform.position.z + i), Quaternion.identity);
                    break;
                }
            }
            CoinSpawn(i);
        }
    }
    void AlternativeStepSpawner2(Collider other)
    {
        if (other.CompareTag("Step") && stepQuantity < LevelConfig.StepQuantity && !doneSpawning && IsSpawner2)
        {
            float chance = Random.Range(0f, 1f); // Chance to instantiate the high step.
            if (lowStepCount >= 5 && chance < 0.2)//It must have at least 5 low steps instantiated in order to instnatiate a high step.
            {
                IsLowStep = false;
                lowStepCount = 0;
            }
            else
            {
                IsLowStep = true;
            }

            GameObject Step = null;

            if (IsLowStep && stepQuantity < LevelConfig.StepQuantity)//If isLowStep is true or all the high steps were already instantiated, instantiate low steps. 
            {
                Step = GameObject.Instantiate(LowStep, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                Step.transform.SetParent(transform);
                lowStepCount++;
            }
            else
            {
                if (stepQuantity < LevelConfig.StepQuantity)//if the number of high steps are still lower than the maximum set for this level.
                {
                    Step = GameObject.Instantiate(HighStep, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                    Step.transform.SetParent(transform);
                    StepSpawner.stepQuantity++;
                }
            }
            float coinChance = Random.Range(0f, 1f);//Chance to instantiate a coin.
            if (coinChance <= 0.35f)
                Instantiate(Coin, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.identity);
        }
        else
        {
            if (stepQuantity >= LevelConfig.StepQuantity && !doneSpawning)
            {
                doneSpawning = true;
                Instantiate(AlternativeFinish,new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            }
        }
    }
    void CoinSpawn(int i)
    {
        float coinChance = Random.Range(0f, 1f);//Chance to instantiate a coin.
        if (coinChance <= 0.35f)
            Instantiate(Coin, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z + i), Quaternion.identity);
    }

}
