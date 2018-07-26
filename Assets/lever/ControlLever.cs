using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLever : MonoBehaviour {

    float leftInput, rightInput;
    Vector3 left;
    Vector3 right;
    Vector3 centerPos;
    public float limit;

	// Use this for initialization
	void Start () {
        left = transform.position + Vector3.left * 7;
        right = transform.position + Vector3.right * 7;

    }
	
	// Update is called once per frame
	void Update () {
        TakeInput();
        if (Mathf.Abs(left.y+leftInput-right.y-rightInput) <limit)
        {

            left.y += leftInput;
            right.y += rightInput;

            centerPos = transform.position;
            centerPos.y = (left.y + right.y) / 2;
            transform.position = centerPos;
            transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.Cross(Vector3.forward, left - right)); 
        }
	}

    void TakeInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            leftInput = 0.1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            leftInput = -0.1f;
        }
        else
            leftInput = 0;

        if (Input.GetKey(KeyCode.O))
        {
            rightInput = 0.1f;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            rightInput = -0.1f;
        }
        else
            rightInput = 0;

        
    }

}
