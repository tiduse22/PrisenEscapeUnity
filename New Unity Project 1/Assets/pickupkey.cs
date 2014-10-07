using UnityEngine;
using System.Collections;

public class pickupkey : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col){

		col.gameObject.GetComponent <test> ().key = true;
		Destroy (gameObject);
		}
}
