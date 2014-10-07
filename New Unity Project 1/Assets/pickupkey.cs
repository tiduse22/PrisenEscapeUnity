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

		GameObject a = GameObject.Find("key");
		test a = col.gameObject.GetComponent <test>();
		a.key = true;
		Destroy (gameObject);
		}
}
