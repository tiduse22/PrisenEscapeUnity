using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    public float speed = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {


		if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(0, 0.1f, 0);
            this.renderer.material.color = Color.red;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(0, -0.1f, 0);
            this.renderer.material.color = Color.green;
        }
		if (Input.GetKey(KeyCode.LeftArrow))
        {
			gameObject.transform.Translate(-0.1f, 0, 0);
            this.renderer.material.color = Color.yellow;
        }
		if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(0.1f, 0, 0);
            this.renderer.material.color = Color.black;
        }
	}
}
