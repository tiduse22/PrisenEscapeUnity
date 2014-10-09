using UnityEngine;
using System.Collections;

public class vision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "Player") {
			Destroy(col.gameObject);

		}
		if (col.gameObject.name == "wall") {
			transform.localScale += new Vector3 (0, 1, 0);
				}				
		}
}
