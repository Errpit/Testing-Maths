using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeScene : MonoBehaviour {

    public GameObject particle;
    public int size;
    

	// Use this for initialization
	void Start () {
        for (float i = -size; i < size; i+=.5f)
        {
            for (float j = -size; j < size; j+=0.5f)
            {
                Instantiate(particle, new Vector3(i, 0.1f, j), Quaternion.identity, transform);
            }
        }	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
