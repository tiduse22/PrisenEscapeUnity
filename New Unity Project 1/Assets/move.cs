using UnityEngine;
using System.Collections;
	
public class move : MonoBehaviour {
	public float speed = 0.1f;

	void Update() {
		transform.Translate (speed, 0, 0);

	}
}