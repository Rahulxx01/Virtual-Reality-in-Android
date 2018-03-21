using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using UnityEngine.SceneManagement;

public class FireBaseScript : MonoBehaviour {
	public InputField EmailAddress,Password;

	public void LogInButtonPressed(){
		FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordAsync(EmailAddress.text,Password.text).
		ContinueWith((obj) => {
			SceneManager.LoadSceneAsync("MainMenu");
		});
			
	}

	public void LogInGooglePlus(){
		//FirebaseAuth.DefaultInstance.S
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
