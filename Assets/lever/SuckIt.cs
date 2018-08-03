using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuckIt : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
            Debug.Log("sucked");
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);

        }
    }
}
