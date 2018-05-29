using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Destroy : MonoBehaviour {

	private List<Collider> collider = new List<Collider>();

	void OnTriggerEnter(Collider col){
		collider.Add(col);
	}

	void OnTriggerExit(Collider col){
		collider.Remove(col);
	}

	void Update(){
		if(Input.GetButtonDown("Destroy") && collider.Count > 0){
			foreach (Collider go in collider) {
				if(go.gameObject.tag=="Box"){
					go.GetComponent<Destroyable>().destroyObject();
					collider.Remove(go);
				}
			}
		}
	}
}
