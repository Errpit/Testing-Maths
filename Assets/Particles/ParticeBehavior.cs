using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticeBehavior : MonoBehaviour {

    public float amplitude;
    public Text debug;
    Vector3 startPosition;
    float distance=1;
    bool entered=false;
    int directionX, directionY=1,directionZ;
    Vector3 other;
    float xValue, zValue;

    // Use this for initialization
    void Start () {
        Debug.Log("start!");
        startPosition = transform.position;
    }

    private void Update()
    {
        if (entered)
        {
              transform.position = Vector3.Lerp(
              transform.position,
              new Vector3(
              startPosition.x
             //+Mathf.Sin((1 - zValue*zValue- xValue*xValue) * Mathf.PI / 4) * amplitude *directionX
             + Mathf.Sin((1 - zValue - xValue) * Mathf.PI / 4) * amplitude * directionX

              ,
              startPosition.y
             + Mathf.Sin((1-xValue-zValue) * Mathf.PI / 4)  *amplitude
             //+ 3 - distance
             // + xValue * xValue + zValue * zValue -2 *(xValue + zValue -1)
              
              ,
              startPosition.z
                // + Mathf.Sin((1 - zValue * zValue - xValue * xValue) * Mathf.PI / 4) * amplitude *directionZ
                + Mathf.Sin((1 - zValue - xValue) * Mathf.PI / 4) * amplitude * directionZ

),
              Time.deltaTime * 5
              );

            #region
            //transform.position = Vector3.Lerp(
            //              transform.position,
            //              new Vector3(
            //                  startPosition.x + directionX * Mathf.Sin(distance / 2 * Mathf.PI) / amplitude,
            //                  .2f,
            //                  startPosition.z + directionZ * Mathf.Sin(distance / 2 * Mathf.PI) / amplitude),
            //                  Time.deltaTime * 10
            //              );


            //transform.position = Vector3.Lerp(
            //  transform.position,
            //  new Vector3(
            //  startPosition.x + (1- other.z),
            //  .2f,
            //  startPosition.z +  (1 - other.x)),
            //  Time.deltaTime * 5
            //  );
            #endregion
        }
    }


    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            distance = Vector3.Distance(startPosition, other.transform.position);
            if (startPosition.x > other.transform.position.x)
            {
                directionX = 1;
            }
            else
            {
                directionX = -1;
            }
            if (startPosition.z > other.transform.position.z)
            {
                directionZ = 1;
            }
            else
            {
                directionZ = -1;
            }

            if (distance<3) {
                this.other=  (other.transform.position - startPosition)/3;
                xValue = Mathf.Abs(this.other.x);
                zValue = Mathf.Abs(this.other.z);
              

                entered = true;

            }
            else
            {
                xValue =zValue= 0.5f;
                
                
                distance = 3;
            }
            //if (debug)
            //    debug.text = distance + "<-distance + vector distance/4 ->" + (Mathf.Sin((1 - Mathf.Abs(xValue) - Mathf.Abs(zValue)) * Mathf.PI / 4) * 2);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        //this.other = Vector3.one;
        entered = false;
    }

}
