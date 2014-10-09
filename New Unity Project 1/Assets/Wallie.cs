using UnityEngine;
using System.Collections;

public class Wallie : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void Update(){
		}
	// Update is called once per frame

	void OnTriggerEnter(Collider col){
		col.transform.localScale -= new Vector3 (1, 1, 0);				
	}
}
