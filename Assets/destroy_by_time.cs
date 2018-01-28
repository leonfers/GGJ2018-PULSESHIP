using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_by_time : MonoBehaviour {

	public float lifetime;
	void Start () {
		Destroy (gameObject, lifetime);
	}

}
