using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 1;
    public float jumpforce = 1;
    public bool canStep = false;
    public bool isDead = false;

    void Start ()
    {
        GetComponent<Animator>().speed = speed * 10f;
    }

    void FixedUpdate () 
    {


        if (Input.GetButton ("Jump") && GetComponent<Rigidbody> ().velocity.y == 0 && canStep) {
            GetComponent<Animator>().Play("Step");
            StartCoroutine(StepDelay());
            canStep = false;
        } else 
        {
            if (GetComponent<Rigidbody>().velocity.y <= 0 && !canStep)
                gameObject.transform.Translate (Vector3.forward * speed);
        }

    }

    IEnumerator StepDelay ()
    {
        yield return new WaitForSeconds(0.6f);
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpforce);
    }
}
