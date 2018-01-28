using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroy_by_contact : MonoBehaviour {


	void OnTriggerEnter(Collider other) 
	{
		if (other.tag=="Player" )
		{
			Destroy (other.gameObject);
            SceneManager.LoadScene("Menu");
		}
        if (other.tag == "bolt")
        {
            Destroy(other.gameObject);
            var health = gameObject.GetComponent<Health>();
            health.health = health.health - 1;
        }
        

	}

}
