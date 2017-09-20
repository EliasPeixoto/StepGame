using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIElements : MonoBehaviour {

    public Text score;
    public GameObject optionsPanel;
    bool isOptionsActive = false;

	void Update () 
    {
        if (Input.GetButtonDown("Cancel"))
            ToggleOptionsPanel();
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
}
