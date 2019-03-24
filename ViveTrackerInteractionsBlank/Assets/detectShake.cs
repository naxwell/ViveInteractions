using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectShake : MonoBehaviour {

   
    public bool isShaking = false;

    Vector3 velocity;
    Vector3 priorPosition;
    public float speed;
    MeshRenderer myMesh;

    // Use this for initialization
    void Start () {
        myMesh = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        velocity = (transform.position - priorPosition) / Time.deltaTime;
        priorPosition = transform.position;

        speed = (Mathf.Abs(velocity.x)) + (Mathf.Abs(velocity.y)) + (Mathf.Abs(-velocity.z));

        //Debug.Log(isShaking);

        if (speed > 1)
        {
            isShaking = true;
            myMesh.material.SetColor("_Color", Color.magenta);

        }
        else
        {
            isShaking = false;
            myMesh.material.SetColor("_Color", Color.cyan);
        }
    }
}
