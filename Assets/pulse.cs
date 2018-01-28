using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulse : MonoBehaviour {

	public GameObject radar;
	public float radius;
	public float pulse_speed;
	bool inflate = true;

	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (inflate) {
			float expansion = Time.deltaTime * pulse_speed;
			radar.transform.localScale += new Vector3 (0.1F * expansion, 1, 0.1F * expansion);
			if (radar.transform.localScale.x > radius) {
				inflate = false;
			}
		} else {
			float expansion = Time.deltaTime * pulse_speed;
			radar.transform.localScale += new Vector3 (0.1F / expansion, 1, 0.1F / expansion);
			if (radar.transform.localScale.x < 1) {
				inflate = true;
			}
		}

		}
		

}
