using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour {

    public GameObject cube;
    public int length;
    GameObject[,] tiles;

	// Use this for initialization
	void Start () {
        tiles = new GameObject[length,length];
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                //Debug.Log((length / 2) - i);
                tiles[i,j] = Instantiate<GameObject>(cube, new Vector3((length / 2) -i, 0.5f, (length / 2) - j), Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                //tiles[i, j].GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
                //Debug.Log((length / 2) - i);
                tiles[i, j].transform.position=new Vector3(tiles[i,j].transform.position.x,  Mathf.Sin(.2f*(tiles[i, j].transform.position.x + tiles[i, j].transform.position.z) +Time.time), tiles[i,j].transform.position.z);
            }
        }
    }
}
