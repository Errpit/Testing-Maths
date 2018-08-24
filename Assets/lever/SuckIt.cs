using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuckIt : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
            Debug.Log("sucked");
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);

        }
    }
}
