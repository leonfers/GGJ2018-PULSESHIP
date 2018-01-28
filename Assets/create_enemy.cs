using UnityEngine;
using System.Collections;

public class create_enemy : MonoBehaviour
{
	public float tumble;
	public Rigidbody rb;

	void Start (){
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * tumble;	
	}
}