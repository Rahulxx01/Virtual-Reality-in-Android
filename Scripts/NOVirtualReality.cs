using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class NOVirtualReality : MonoBehaviour {

	public void Start () {
		StartCoroutine (DeactivatorVR("none"));
	}
	
	public IEnumerator DeactivatorVR(string noVR){
		XRSettings.LoadDeviceByName (noVR);
		yield return null;
		XRSettings.enabled = false;

	}
}
