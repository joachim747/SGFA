using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_CameraControl : MonoBehaviour {

	public Transform m_CurrentMount;
	public Transform[] m_Mounts;
	public float m_Speed = 0.1f;

	// Use this for initialization
	void Start () {
		//GameObject.Find("Page_Level").SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp(transform.position, m_CurrentMount.position, m_Speed);
		transform.rotation = Quaternion.Slerp(transform.rotation, m_CurrentMount.rotation, m_Speed);
	}

	//Transform newMount
	public void setMount(int slide){
		m_CurrentMount = m_Mounts[slide];
	}
}
