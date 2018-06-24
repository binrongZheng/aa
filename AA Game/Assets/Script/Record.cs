using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour {

	public Text scoreText;

	private void Start () {
		scoreText.text=PlayerPrefs.GetInt("score").ToString();
	}

}
