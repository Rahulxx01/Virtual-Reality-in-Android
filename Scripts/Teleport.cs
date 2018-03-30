using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
	
	public int floorLevel;

	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
			SceneManager.LoadScene (floorLevel);
			//Application.LoadLevelAdditive(floorLevel);
		}
	
	}


}
