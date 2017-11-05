using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlternativeStepDestroyer : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Step"))
            Destroy(other.gameObject);
        else
        {
            if (other.CompareTag("Coin"))
            {
                Destroy(other.gameObject);
            }
        }
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Restart(other.gameObject));
        }
    }
    IEnumerator Restart(GameObject player)
    {
        StepMovement.isEnabled = false;
        Destroy(player);//Kills the character.
        yield return new WaitForSeconds(5f);
        LevelConfig.RestartCourse();
        SceneManager.LoadScene(2);
    }
}
