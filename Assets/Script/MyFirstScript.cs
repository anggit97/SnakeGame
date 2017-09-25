using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour {

	public GameObject myObj;
	public GameObject myBase;
	public GameObject thePrefab;
	Transform myTransform;

	// Use this for initialization
	void Start () {
		myObj = GetComponent<GameObject> ();
		myBase = GetComponent<GameObject> ();

		myTransform = GetComponent<Transform> ();
	}
	 	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("space")){
			Instantiate (thePrefab);
		}
	}

	void OnCollisionEnter(Collision collision){ 	
		if(collision.gameObject.name == "Base"){
			GameObject.Find ("Cube").SetActive (false);
		}


	}
}
