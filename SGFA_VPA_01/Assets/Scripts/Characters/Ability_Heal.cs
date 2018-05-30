using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Heal : MonoBehaviour {

	public List<GameObject> heroes = new List<GameObject>();

	void Start() {
		heroes.Add(gameObject.transform.parent.gameObject);
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			heroes.Add(col.gameObject);
		}
	}

	void OnTriggerExit(Collider col) {
		if(col.gameObject.tag == "Player"){
			heroes.Remove(col.gameObject);
		}
	}

	void Update () {
		if(Input.GetButtonDown("Heal")){
			foreach (GameObject go in heroes) {
				Debug.Log("Triggered");
				go.GetComponent<PlayerHealth>().IncreaseHealth(50f);
			}
		}
	}
}
