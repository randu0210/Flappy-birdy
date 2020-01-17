using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gamemanager : MonoBehaviour {

	public GameObject gameOverCanvas;

	private void Start()
	{
		gameOverCanvas.SetActive(false);
		Time.timeScale=1;
	}
	public void GameOver()
	{
		gameOverCanvas.SetActive(true);
		Time.timeScale=0;
	}
	public void Replay()
	{
		SceneManager.LoadScene(0);
	}
}
