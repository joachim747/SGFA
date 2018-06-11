using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Navigation : MonoBehaviour {

	[Range(0,23)] public int m_Count = 0;
	public GameObject CameraRig;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Forward")){
			m_Count++;
			CameraRig.GetComponent<Menu_CameraControl>().setMount(m_Count);
		} 
		else if(Input.GetButtonDown("Backward")){
			m_Count--;
			CameraRig.GetComponent<Menu_CameraControl>().setMount(m_Count);
		}
		else if(Input.GetButtonDown("Quit")) {
			Application.Quit();
		}
	}
}
