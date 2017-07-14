using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratePipes : MonoBehaviour {
	public GameObject pipes;
	public Text scoreText;

	private int score = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating("createPipes", 1f, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score;
		PlayerPrefs.SetInt("highScore", score);
	}

	void createPipes() {
		Instantiate(pipes);
		//Implement Score TExt
		score++;
	}
}
