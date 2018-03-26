using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GazeInterationScript : MonoBehaviour {

	// Use this for initialization
	public float MyTime = 0f;
	public int sceneInteger;
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {

		MyTime += Time.deltaTime;
		if(MyTime >= 3f){
			changeScreen(sceneInteger);
		}
		
	}

	public void changeScreen(int changeScene){
		SceneManager.LoadScene (changeScene);
	}


}
