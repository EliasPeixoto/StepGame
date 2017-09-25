using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIElements : MonoBehaviour {

    public Text score;
    public InputField numberOfSteps;
    public InputField increment;
    public GameObject configPanel;
    public GameObject mainPanel;
    public GameObject optionsPanel;
    bool isOptionsActive = false;

	void Update () 
    {
        if (Input.GetButtonDown("Cancel") && optionsPanel != null)
            ToggleOptionsPanel();
        if(score != null)
            score.text = "Score: " + PlayerScore.Score;
	}

    public void ToggleOptionsPanel ()
    {
        if (isOptionsActive == false)
        {
            optionsPanel.SetActive(true);
            isOptionsActive = true;
        }

        else
        {
            optionsPanel.SetActive(false);
            isOptionsActive = false;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ActivateConfigPanel()
    {
        mainPanel.SetActive(false);
        configPanel.SetActive(true);
    }

    public void StepQuantityConfig()
    {
        int n = Convert.ToInt32(numberOfSteps.text);
        if (n > 0)
        {    
            LevelConfig.StepQuantity = n;
            numberOfSteps.GetComponent<Image>().color = Color.green;
            numberOfSteps.interactable = false;
        }
        else
        {
            numberOfSteps.text = " ";
            numberOfSteps.GetComponent<Image>().color = Color.red;
        }
    }
    public void IncrementConfig()
    {
        int n = Convert.ToInt32(increment.text);
        if (n > 0)
        {
            LevelConfig.Increment = n;
            increment.GetComponent<Image>().color = Color.green;
            increment.interactable = false;
        }
        else
        {
            increment.text = " ";
            increment.GetComponent<Image>().color = Color.red;
        }
    }
}

