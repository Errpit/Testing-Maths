using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScaler : MonoBehaviour {

    public Transform point1, point2;
    Vector3 direction;
    public GameObject wall;
    float distance;

	// Use this for initialization
	void Start () {
		distance=(point2.position-point1.position).magnitude;
        Debug.Log(distance.ToString());
        wall.transform.localScale = new Vector3(wall.transform.localScale.x,wall.transform.localScale.y,distance/wall.transform.localScale.z);
        wall.transform.position=(point1.position+point2.position)/ 2;
        wall.transform.LookAt(point1.localPosition)  ;


        //float deltaX= point2.position.x - point1.position.x;
        //float deltaZ= point2.position.z - point1.position.z;
        //float rad = Mathf.Atan2(deltaZ, deltaX);
        //Vector3 direct=new Vector3(Mathf.Cos(rad), 0, Mathf.Sin(rad));
        //direction = Vector3.Cross(point2.localPosition-point1.localPosition, Vector3.up);
        //Debug.Log(direction.ToString());

        //Debug.Log((point2.localPosition - point1.localPosition).ToString());
        //Debug.Log(new Vector3(Mathf.Cos(rad), 0, Mathf.Sin(rad)).ToString());
        //wall.transform.localRotation = Quaternion.FromToRotation(point2.position , point1.position);
        //wall.transform.rotation.

    }

    // Update is called once per frame
    void Update () {
		
	}
}
