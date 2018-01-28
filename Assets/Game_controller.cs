using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_controller : MonoBehaviour {

	public GameObject Enemy;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	public TextMesh scoreText;
	public int score;

	void Start()
	{
		scoreText.text = "" + 0;
		UpdateScore ();
		StartCoroutine(SpawnWaves ());
	}
	public void AddScore(int points){
		score += points;
		UpdateScore ();
	}
	void UpdateScore(){
		scoreText.text = "Pontos: " + score;
	}

	IEnumerator SpawnWaves(){
		if (score == 0) {
			yield return new WaitForSeconds (startWait);
		} else {
			yield return new WaitForSeconds (startWait);
		}

		while (true) {
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (Enemy, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (waveWait);
			}

		}
	}

}

