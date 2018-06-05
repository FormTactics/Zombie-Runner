using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    

    private bool called = false;
    private Rigidbody Rigidbody;

	// Use this for initialization
	void Start () {
        Rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
       
        
    }

    void OnDisatchHelicopter ()
    {
            
        Debug.Log("Helicopter called");
        Rigidbody.velocity = new Vector3(0, 0, 50f);
        called = true;
    
    }
}
