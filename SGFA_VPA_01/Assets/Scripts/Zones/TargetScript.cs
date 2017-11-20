using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour {

	//in general it should be checked, if the colliding gameobject is of type player, else errors could occur

	private bool achieved = false;
	private int actPlayerNumber, otherPlayerNumber;

	void OnTriggerEnter(Collider col){
		col.gameObject.GetComponent<PlayerSettings>().setTargetState(true);
	}

	void OnTriggerStay(Collider col){
		
	}

	void OnTriggerExit(Collider col){
		col.gameObject.GetComponent<PlayerSettings>().setTargetState(false);

	}

	

}
