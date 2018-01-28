using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_by_contact : MonoBehaviour {


	void OnTriggerEnter(Collider other) 
	{
		if (other.tag=="Player" || other.tag == "bolt")
		{
			Destroy (other.gameObject);
			var health = gameObject.GetComponent<Health> ();
			health.health = health.health -1;
		}

	}

}
