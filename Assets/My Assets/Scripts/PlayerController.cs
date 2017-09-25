using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 1;//character Speed.
    public float jumpforce = 1;//character jumpforce
    public bool canStep = false;//Determines whether the character can or cannot step.
    public bool isDead = false;//Store if the character is dead or not.

    void Start ()
    {
        GetComponent<Animator>().speed = speed * 10f;//Sets the velocity of the running animation according with its speed.
    }

    void FixedUpdate () 
    {


        if (Input.GetButton("Jump") && GetComponent<Rigidbody>().velocity.y == 0 && canStep) //if the character is not jumping or falling and canStep is true.
        {
            GetComponent<Animator>().Play("Step");//Plays the Step animation.
            StartCoroutine(StepDelay());//Delays the character movement for a better Animation/Movement Sychronization.
            canStep = false;
        }         else 
        {
            if (GetComponent<Rigidbody>().velocity.y <= 0 && !canStep)//if the character is  jumping or falling and canStep is false.
                gameObject.transform.Translate (Vector3.forward * speed);//It Makes the character go forward.
        }

    }

    IEnumerator StepDelay ()
    {
        yield return new WaitForSeconds(0.6f);
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpforce);//It makes the character jump.
    }
}
