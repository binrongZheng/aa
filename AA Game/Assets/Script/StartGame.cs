using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
	public void clickButton(){
		SceneManager.LoadScene("MainLevel");
	}

	public void exitButton(){
		Application.Quit();
	}
}

