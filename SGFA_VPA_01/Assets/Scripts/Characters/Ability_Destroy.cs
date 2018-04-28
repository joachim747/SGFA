using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Destroy : MonoBehaviour {

	private Collider collider;

	void OnTriggerEnter(Collider col){
		collider = col;
	}

	void OnTriggerExit(){
		collider = null;
	}

	void Update(){
		if(Input.GetButtonDown("Destroy")){
			if(collider != null && collider.gameObject.tag == "Box"){
				Destroy(collider.gameObject);
			}
		}
	}
}
