using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		var door = GameObject.Find ("firstDoor");

		if (col.gameObject.GetComponent <test>().key == true) 
		{
			door.collider.enabled = !door.collider.enabled;
				}
	}

}
