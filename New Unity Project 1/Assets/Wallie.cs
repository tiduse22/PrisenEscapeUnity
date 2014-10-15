using UnityEngine;
using System.Collections;

public class Wallie : MonoBehaviour {
	// Use this for initialization
	void Start () {
		if (this.name == "visionleft") {
			this.renderer.enabled = false;
			this.collider.enabled = false;
				}
	}

	void Update(){
		}
	// Update is called once per frame

	void OnTriggerEnter(Collider col){
		if (col.name == "wall") {
						transform.localScale -= new Vector3 (2, 2, 0);
			if (name == "visionright"){
						transform.position -= new Vector3 (1, 0, 1);
			}
			else if (name == "visionleft") {
				transform.position -= new Vector3 (-1, 0, 1);
			}

				}
		else if (col.name == "Player") {
			Destroy(col.gameObject);
				}
	}
}
