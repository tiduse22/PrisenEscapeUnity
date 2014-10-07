using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	public bool key = false;
	public bool Key {
		get { return key; }
		set { key = value; }
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Setkey(bool Key){
		key = true;
		}
}
