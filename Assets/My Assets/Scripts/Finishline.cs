using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour {

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
            StartCoroutine(ControledEnd(other.gameObject));
    }

    IEnumerator ControledEnd (GameObject player)
    {   
        yield return new WaitForSeconds(2f);
        player.GetComponent<PlayerController>().enabled = false;//Disable player controller at the end of the course.
        player.GetComponent<Animator>().SetBool("CanStep", true);//It Makes the idle animation start.
        LevelConfig.CouseFinished();//See LevelConfig script
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);//It Loads the current scene.
    }
}
