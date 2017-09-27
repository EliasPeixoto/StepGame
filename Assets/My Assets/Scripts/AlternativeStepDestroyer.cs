using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternativeStepDestroyer : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Step"))
            Destroy(other.gameObject);
    }
}
