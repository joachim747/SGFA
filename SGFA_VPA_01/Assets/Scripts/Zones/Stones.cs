using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stones : MonoBehaviour {

	Animator animator;
	public int player;
	//public int number;
	//public GameObject ActivationHandler;

	void Start () {
		animator = transform.parent.GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider other) {
		if(player == other.GetComponent<PlayerMovement>().m_PlayerNumber){
			animator.Play("Move_Up");
			//ActivationHandler.GetComponent<ActivationHandler>().setActivation(number);
		}
	}
}
