using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternativePlayerController : MonoBehaviour {

    public float jumpforce = 1;
    public GameObject RightHand;
    public GameObject LeftHand;

    void FixedUpdate () 
    {
        Step();
        RightHandLow();
        LeftHandLow();
        RightHandHigh();
        LeftHandHigh();
    }
    IEnumerator StepDelay ()
    {
        yield return new WaitForSeconds(0.6f);
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpforce);//It makes the character jump.
        StepMovement.isEnabled = true;
    }
    void Step ()
    {
        if (Input.GetButton("Jump") && GetComponent<Animator>().GetBool("Idle")) //if the character is not jumping or falling and canStep is true.
        {
            StartCoroutine(StepDelay());//Delays the character movement for a better Animation/Movement Sychronization.
            GetComponent<Animator>().SetTrigger("Step");
            GetComponent<Animator>().SetBool("Idle", false);
        }
    }

    void RightHandLow()
    {
        if (Input.GetButton("RightHandLow") && !GetComponent<Animator>().GetBool("Idle"))
        {
            GetComponent<Animator>().SetBool("RightHandLow", true);
            RightHand.SetActive(true);
            RightHand.transform.localPosition = new Vector3(RightHand.transform.localPosition.x, 0.8f, RightHand.transform.localPosition.z);
        }
        else
        {
            if (!Input.GetButton("RightHandHigh"))
            {
                GetComponent<Animator>().SetBool("RightHandLow", false);
                RightHand.SetActive(false);
            }
        }
    }

    void LeftHandLow()
    {
        if (Input.GetButton("LeftHandLow") && !GetComponent<Animator>().GetBool("Idle"))
        {
            GetComponent<Animator>().SetBool("LeftHandLow", true);
            LeftHand.SetActive(true);
            LeftHand.transform.localPosition = new Vector3(LeftHand.transform.localPosition.x, 0.8f, LeftHand.transform.localPosition.z);
        }
        else
        {
            if (!Input.GetButton("LeftHandHigh"))
            {
                GetComponent<Animator>().SetBool("LeftHandLow", false);
                LeftHand.SetActive(false);
            }
        }
    }

    void RightHandHigh()
    {
        if (Input.GetButton("RightHandHigh") && !GetComponent<Animator>().GetBool("Idle"))
        {
            GetComponent<Animator>().SetBool("RightHandHigh", true);
            RightHand.SetActive(true);
            RightHand.transform.localPosition = new Vector3(RightHand.transform.localPosition.x, 1.35f, RightHand.transform.localPosition.z);
        }
        else
        {
            if (!Input.GetButton("RightHandLow"))
            {
                GetComponent<Animator>().SetBool("RightHandHigh", false);
                RightHand.SetActive(false);
            }
        }
    }

    void LeftHandHigh()
    {
        if (Input.GetButton("LeftHandHigh") && !GetComponent<Animator>().GetBool("Idle"))
        {
            GetComponent<Animator>().SetBool("LeftHandHigh", true);
            LeftHand.SetActive(true);
            LeftHand.transform.localPosition = new Vector3(LeftHand.transform.localPosition.x, 1.35f, LeftHand.transform.localPosition.z);
        }
        else
        {
            if (!Input.GetButton("LeftHandLow"))
            {
                GetComponent<Animator>().SetBool("LeftHandHigh", false);
                LeftHand.SetActive(false);
            }
        }
    }
}

