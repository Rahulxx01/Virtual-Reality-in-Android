using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {
	public Material look;
	public Material notLook;
	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().material = notLook;
	}
	
	public void TotallyWatching(){
		GetComponent<Renderer> ().material = look;
	}

	public void notWatching(){
		GetComponent<Renderer> ().material = notLook;
	}
}
