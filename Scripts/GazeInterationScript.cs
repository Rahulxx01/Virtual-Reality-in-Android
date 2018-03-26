using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GazeInterationScript : MonoBehaviour {

	// Use this for initialization
	public float MyTime = 0f;

	public Transform radialProgress;
	public int sceneInteger;
	void Start () {
		radialProgress.GetComponent<Image> ().fillAmount = MyTime;
		
	}
	
	// Update is called once per frame
	public void Update () {

		MyTime += Time.deltaTime;
		radialProgress.GetComponent<Image> ().fillAmount = MyTime/10;
		if(MyTime >= 10f){
			//changeScreen(sceneInteger);
			SceneManager.LoadScene (sceneInteger);
		}
		
	}

	public void Reset(){
		MyTime = 0f;
		radialProgress.GetComponent<Image> ().fillAmount = MyTime;
	}

	public void changeScreen(int changeScene){
		
	}


}
