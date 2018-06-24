using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	private bool gameHasEnded = false;

	public Rotator rotator;
	public Spawner Spawner;

	public Animator animator;
	public GameObject Pannel;

	public void EndGame(){
		if(gameHasEnded)
			return;

		rotator.enabled=false;
		Spawner.enabled=false;

		animator.SetTrigger("EndGame");

		gameHasEnded=true;
	}

	public void RestartLevel(){
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Pannel.SetActive(true);
	}

	public void OnButtonClick(string sceneName){
		SceneManager.LoadScene(sceneName);
	}
}
