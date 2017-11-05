using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {

    public float speed = 1;//character Speed.
    public float jumpforce = 1;//character jumpforce
    public bool canStep = false;//Determines whether the character can or cannot step.
    public bool isDead = false;//Store if the character is dead or not.
    public GameObject RightHand;
    public GameObject LeftHand;

    void Start ()
    {
        GetComponent<Animator>().speed = speed * 10f;//Sets the velocity of the running animation according with its speed.
    }

    void FixedUpdate () 
    {
        Step();
        RightHandLow();

      

    }

    void Step ()
    {
        if (Input.GetButton("Jump") && GetComponent<Rigidbody>().velocity.y == 0 && GetComponent<Animator>().GetBool("Idle")) //if the character is not jumping or falling and canStep is true.
        {
            StartCoroutine(StepDelay());//Delays the character movement for a better Animation/Movement Sychronization.
            GetComponent<Animator>().SetTrigger("Step");
            GetComponent<Animator>().SetBool("Idle", false);

        }
        else
        {
            if (GetComponent<Rigidbody>().velocity.y <= 0 && !GetComponent<Animator>().GetBool("Idle"))//if the character is  jumping or falling and canStep is false.
                gameObject.transform.Translate(Vector3.forward * speed);//It Makes the character go forward.
        }
    }

    void RightHandLow ()
    {
        if (Input.GetButton("RightHandLow") && !GetComponent<Animator>().GetBool("Idle"))
        {
            GetComponent<Animator>().SetBool("HandLow",true);
            RightHand.SetActive(true);
        }
        else
        {
            GetComponent<Animator>().SetBool("RightHandLow", false);
            RightHand.SetActive(false);
        }
    }

    void LeftHandLow() 
    {
        if (Input.GetButton("RightHandLow") && GetComponent<Rigidbody>().velocity.y == 0 && GetComponent<Animator>().GetBool("CanStep"))
        {
            GetComponent<Animator>().SetBool("HandLow", true);
                
        }
    }

    void RightHandHigh()
    {

    }

    void LeftHandHigh()
    {

    }

    IEnumerator StepDelay ()
    {
        yield return new WaitForSeconds(0.6f);
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpforce);//It makes the character jump.
    }
}
