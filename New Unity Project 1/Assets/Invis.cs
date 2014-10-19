using UnityEngine;
using System.Collections;

public class Invis : MonoBehaviour {
	public GameObject visionOn = null;
	public GameObject visionOff = null;

    const float VISION_SCALE_X = 9;
    const float VISION_SCALE_Y = 7;
    const float VISIONRIGHT_POSITION_X = 4.805511f;
    const float VISIONLEFT_POSITION_X = -4.805511f;
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
					visionOff = GameObject.Find("visionright"); // Turns off vision for the right vision
                    visionOn = GameObject.Find("visionleft"); // Turns on vision for the left vision
					visionOff.renderer.enabled = false;
					visionOff.collider.enabled = false;
					visionOn.renderer.enabled = true;
					visionOn.collider.enabled = true;
                    visionOn.transform.localScale = new Vector3(VISION_SCALE_X, VISION_SCALE_Y, 0);
                    visionOn.transform.localPosition = new Vector3(VISIONLEFT_POSITION_X, visionOn.transform.localPosition.y, 0);
				}
				else if (name == "PatrolCube2") {
					col.gameObject.GetComponent<move>().speed = -col.gameObject.GetComponent<move>().speed;
					visionOff = GameObject.Find("visionleft"); // Turns off vision for the left vision
                    visionOn = GameObject.Find("visionright"); // Turns on vision for the right vision
					visionOff.renderer.enabled = false;
					visionOff.collider.enabled = false;
					visionOn.renderer.enabled = true;
					visionOn.collider.enabled = true;
                    visionOn.transform.localScale = new Vector3(VISION_SCALE_X, VISION_SCALE_Y, 0);
                    visionOn.transform.localPosition = new Vector3(VISIONRIGHT_POSITION_X, visionOn.transform.localPosition.y, 0);
				}

				}
		}
}
