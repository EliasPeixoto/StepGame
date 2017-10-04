using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlternativeFinish : MonoBehaviour {

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
            StartCoroutine(ControledEnd(other.gameObject));
    }

    IEnumerator ControledEnd (GameObject player)
    {   
        yield return new WaitForSeconds(0.1f);
        StepMovement.isEnabled = false;
        player.GetComponent<AlternativePlayerController>().enabled = false;//Disable player controller at the end of the course.
        player.GetComponent<Animator>().SetBool("CanStep", true);//It Makes the idle animation start.
        LevelConfig.CouseFinished();
        Debug.Log(AlternativeStepSpawner.stepQuantity + " " + LevelConfig.StepQuantity);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(2);//It Loads the current scene.
    }
}
