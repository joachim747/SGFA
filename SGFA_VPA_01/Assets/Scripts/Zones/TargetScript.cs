using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour {

	//in general it should be checked, if the colliding gameobject is of type player, else errors could occur

	void OnTriggerEnter(Collider col){
		col.gameObject.GetComponent<PlayerSettings>().setTargetState(true);
	}

	void OnTriggerExit(Collider col){
		col.gameObject.GetComponent<PlayerSettings>().setTargetState(false);

	}

	

}
