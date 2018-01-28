using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reveal : MonoBehaviour {
	public float lit;
	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "enemy") {
			Renderer rend = other.gameObject.GetComponent<Renderer> ();
			rend.enabled = true;
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "enemy") {
			StopCoroutine (hide(other));
			StartCoroutine (hide(other));
		}
	}
	IEnumerator hide(Collider other){
		yield return new WaitForSeconds(lit);
		Renderer rend = other.gameObject.GetComponent<Renderer> ();
		rend.enabled = false;
	}
}
