using UnityEngine;
using System.Collections;

public class Invis : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
			if (col.name == "npc") {
			col.gameObject.GetComponent<move>().speed = -col.gameObject.GetComponent<move>().speed;

				}
		}
}
