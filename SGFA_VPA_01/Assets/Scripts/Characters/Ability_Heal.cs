using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Heal : MonoBehaviour {

	public List<GameObject> heroes = new List<GameObject>();
	private List<GameObject> humans = new List<GameObject>();

	void Start() {
		heroes.Add(gameObject.transform.parent.gameObject);
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			heroes.Add(col.gameObject);
		}
		if(col.gameObject.tag == "Human_Subpart"){
			humans.Add(col.transform.parent.gameObject);
		}
	}

	void OnTriggerExit(Collider col) {
		if(col.gameObject.tag == "Player"){
			heroes.Remove(col.gameObject);
		}
		if(col.gameObject.tag == "Human_Subpart"){
			humans.Remove(col.transform.parent.gameObject);
		}
	}

	void Update () {
		if(Input.GetButtonDown("Heal")){
			foreach (GameObject go in heroes) {
				go.GetComponent<PlayerHealth>().IncreaseHealth(50f);
			}
			foreach (GameObject go in humans){
				go.GetComponent<PlayerHealth>().IncreaseHealth(50f);
			}
		}
	}
}
