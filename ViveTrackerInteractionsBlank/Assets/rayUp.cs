using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayUp : MonoBehaviour {


	// Use this for initialization
	void Start () {
       
      
	}
	
	// Update is called once per frame
	void Update () {
        Ray Ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward, Color.green);


        if (Physics.Raycast(Ray, out hit))
        {
            
                Debug.Log(hit.collider.gameObject.name);
           
        }

	}
}
