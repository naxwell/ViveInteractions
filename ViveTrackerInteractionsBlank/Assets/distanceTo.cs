using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceTo : MonoBehaviour {

    public Transform target;
    public float distance;


    MeshRenderer myMesh;


	// Use this for initialization
	void Start () {
        myMesh = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        distance = Vector3.Distance(target.position, transform.position);


        if (distance < 0.5)
        {
            myMesh.material.SetColor("_Color", Color.green);
            Debug.Log("so close");
        }
        else
        {
            myMesh.material.SetColor("_Color", Color.cyan);
        }

	}
}
