using UnityEngine;
using System.Collections;

public class shot : MonoBehaviour{
	public float speed;
	public Rigidbody rb;
	void Start(){
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.up * speed;
	}
}