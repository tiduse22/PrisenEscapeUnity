﻿using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.name == "door")
		{
			//Destroy(col.gameObject);
			col.collider.enabled = false;

		}
		}

}
