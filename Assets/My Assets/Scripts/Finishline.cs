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
        player.GetComponent<PlayerController>().enabled = false;
        player.GetComponent<Animator>().SetBool("CanStep", true);
        LevelConfig.CouseFinished();
        Debug.Log("Couse Finished");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }
}
