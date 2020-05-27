using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void restartGame()
	{
		 SceneManager.LoadScene("MainScene");
        //Работает ...сцена перезагружается
		//Application.LoadLevel(Application.loadedLevel);
	}

	public void backTomainMenu(){
		SceneManager.LoadScene("StartMenu");
	}
}
