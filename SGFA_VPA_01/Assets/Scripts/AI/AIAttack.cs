using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAttack : MonoBehaviour {

	private List<GameObject> targets = new List<GameObject>();
	public float m_DamageToPlayer = 0.2f;

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			targets.Add(col.gameObject);
		}
	}

	void OnTriggerExit(Collider col){
		if(col.gameObject.tag == "Player"){
			targets.Remove(col.gameObject);
		}
	}

	void OnTriggerStay(){
		if(targets.Count > 0){
			foreach (GameObject go in targets) {
				go.GetComponent<PlayerHealth>().TakeDamage(m_DamageToPlayer);
			}
		}
	}
}
