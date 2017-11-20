using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour {

	Animator animator;
	bool bridgeRisen;

	// Use this for initialization
	void Start () {
		bridgeRisen = false;
		animator = transform.parent.GetComponent<Animator>();
		//animator = GetComponentInParent<Animator>();

	}
	
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			bridgeRisen = true;
			BridgeControl("Risen");
		}
	}

	void OnTriggerExit(Collider col){
		if(col.gameObject.tag == "Player"){
			bridgeRisen = false;
			BridgeControl("Lowered");
		}
	}

	void BridgeControl(string comand){
		animator.SetTrigger(comand);
	}

}
