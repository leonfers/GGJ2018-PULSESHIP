using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public float health;
	public GameObject c;
	private Game_controller gc;
	// Use this for initialization

	void Start () {
		GameObject G = GameObject.FindWithTag ("GameController");
		if (G != null) {
			gc = G.GetComponent<Game_controller> ();
		}
		if (gc == null) {
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			gc.AddScore (3);
			Destroy (gameObject);
		}
	}
}
