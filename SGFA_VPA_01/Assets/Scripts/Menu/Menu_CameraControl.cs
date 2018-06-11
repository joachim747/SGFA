using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_CameraControl : MonoBehaviour {

	public Transform m_CurrentMount;
	public float m_Speed = 0.1f;

	// Use this for initialization
	void Start () {
		GameObject.Find("Page_Controls").SetActive(false);
		GameObject.Find("Page_Settings").SetActive(false);
		GameObject.Find("Page_Quit").SetActive(false);
		GameObject.Find("Page_Level").SetActive(false);
		GameObject.Find("Page_About").SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp(transform.position, m_CurrentMount.position, m_Speed);
		transform.rotation = Quaternion.Slerp(transform.rotation, m_CurrentMount.rotation, m_Speed);
	}

	public void setMount(Transform newMount){
		m_CurrentMount = newMount;
	}
}
