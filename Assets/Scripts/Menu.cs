using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public Text ScoreText;
	private int oldHS;

	// Use this for initialization
	void Start () {
		int HighScore = PlayerPrefs.GetInt("highScore");
		StoreHighScore(HighScore);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Play() {
		Application.LoadLevel("Demo Scene");
	}

	void StoreHighScore(int newHS) {
		oldHS = PlayerPrefs.GetInt("OldHighScore");
		if (newHS > oldHS) {
			PlayerPrefs.SetInt("OldHighScore", newHS);
			ScoreText.text = "High Score: " + newHS;
		} else {
			ScoreText.text = "High Score: " + oldHS;
		}
	}
}
