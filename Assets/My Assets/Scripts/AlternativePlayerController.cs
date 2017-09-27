using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternativePlayerController : MonoBehaviour {

    public float jumpforce = 1;

    void FixedUpdate () 
    {


        if (Input.GetButton("Jump") && GetComponent<Rigidbody>().velocity.y == 0 && GetComponent<Animator>().GetBool("CanStep")) //if the character is not jumping or falling and canStep is true.
        {
            GetComponent<Animator>().Play("Step");//Plays the Step animation.
            StartCoroutine(StepDelay());//Delays the character movement for a better Animation/Movement Sychronization.
            GetComponent<Animator>().SetBool("CanStep",false);
        }        
    }
    IEnumerator StepDelay ()
    {
        yield return new WaitForSeconds(0.6f);
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpforce);//It makes the character jump.
        StepMovement.isEnabled = true;
    }
}
