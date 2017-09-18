using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 1;
    public float jumpforce = 1;
    public bool canStep = false;



    void FixedUpdate () 
    {


        if (Input.GetButton ("Jump") && GetComponent<Rigidbody> ().velocity.y == 0 && canStep) {
            GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpforce);
            canStep = false;
        } else 
        {
            if (GetComponent<Rigidbody>().velocity.y <= 0 && !canStep)
                gameObject.transform.Translate (Vector3.forward * speed);
        }

    }
}
