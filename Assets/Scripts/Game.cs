using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Game : MonoBehaviour {

	private static GameObject gameCanvas;
	private static GameObject gameOverCanvas;

	public static bool isGameOver = false;
	// Use this for initialization
	void Start () {
		gameCanvas = GameObject.Find("GameCanvas");
		gameOverCanvas = GameObject.Find("GameOverCanvas");
		gameOverCanvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public static void GameOver(){
		if (isGameOver) return;

		isGameOver = true;
		gameCanvas.SetActive(false);
		gameOverCanvas.SetActive(true);

		GameObject.Find("GameOverTime").GetComponent<Text>().text = "" +Time.timeSinceLevelLoad;
	}
}
