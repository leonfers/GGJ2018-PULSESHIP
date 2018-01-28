using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

	public Rigidbody rb;
	void Start(){
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.forward * Random.Range(-4,-10);
	}
}
