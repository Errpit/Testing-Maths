using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour {

    public Button interactButton;
    bool interactButtonDown=false;
    Rigidbody rig;
    public float force=1f;
	// Use this for initialization
	void Start () {
       interactButton.gameObject.SetActive(false);
	}

    public void SetButton()
    {
        Debug.Log("NearDoor");
        interactButtonDown = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Door"))
        {
            interactButtonDown = false;
                interactButton.gameObject.SetActive(true);
            rig = other.gameObject.GetComponent<Rigidbody>();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Door") && rig!=null)
        {
            if (interactButtonDown)
            {
                Debug.Log("Attempting open");
                rig.AddForce(transform.forward * force);
                interactButtonDown = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Door"))
        {
            interactButton.gameObject.SetActive(false);
            rig = null;
            interactButtonDown = false;
        }
    }
   
}
