using UnityEngine;
using System.Collections;

public class Invis : MonoBehaviour {
	public GameObject visionOn = null;
	public GameObject visionOff = null;
	// Use this for initialization
	void Start () {
		gameObject.renderer.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
			if (col.name == "npc") {
				if (name == "PatrolCube1") {
					col.gameObject.GetComponent<move>().speed = -col.gameObject.GetComponent<move>().speed;
					visionOff = GameObject.Find("visionright");
					visionOn = GameObject.Find("visionleft");
					visionOff.renderer.enabled = false;
					visionOff.collider.enabled = false;
					visionOn.renderer.enabled = true;
					visionOn.collider.enabled = true;
				}
				else if (name == "PatrolCube2") {
					col.gameObject.GetComponent<move>().speed = -col.gameObject.GetComponent<move>().speed;
					visionOff = GameObject.Find("visionleft");
					visionOn = GameObject.Find("visionright");
					visionOff.renderer.enabled = false;
					visionOff.collider.enabled = false;
					visionOn.renderer.enabled = true;
					visionOn.collider.enabled = true;
				}

				}
		}
}
