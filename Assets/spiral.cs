using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiral : MonoBehaviour {

    public float magni;
    Vector3 direction;
	// Use this for initialization
	void Start () {
		direction= new Vector3();
    }
	
	// Update is called once per frame
	void Update () {
        direction =new Vector3(Mathf.Cos(Time.time ), Mathf.Sin(Time.time*.5f), Mathf.Cos(Time.time * .2f));
        transform.position += direction;
	}
}
