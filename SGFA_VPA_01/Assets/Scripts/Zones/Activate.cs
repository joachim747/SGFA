using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour {
	Animator animator;
	public GameObject[] m_objects;

	void OnTriggerEnter(Collider collider){
		if(collider.gameObject.tag == "Player"){
			Debug.Log("Triggered");
			for(int i=0; i<m_objects.Length;i++){
				Debug.Log(i);
				animator = m_objects[i].GetComponent<Animator>();
				animator.Play("StonesBridgeRise");
			}
			Debug.Log("Schleife endet");
		}
	}
}
